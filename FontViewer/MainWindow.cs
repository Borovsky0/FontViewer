using FontViewer.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FontViewer
{
    public partial class MainWindow : Form
    {
        #region CONSTANTS
        readonly string[] allowedExtensions = { ".ttf", ".otf", ".ttc", ".otc" };       // Extensions for font files supported by the app
        readonly string[,] pangram = new string[,]                                      // String array with pangrams and their short names (delete from code later)
        {
            {"RUS", "ENG", "1?*"},
            {"Съешь же ещё этих мягких французских булок, да выпей чаю.",
            "The quick brown fox jumps over the lazy dog.",
            "1234567890.,!?@#$%&№`\"^<>*-—~+=:;({[]})\\|/"}
        };
        #endregion

        #region REQUIRED VARIABLES
        bool shortTabNames = Settings.Default.shortTabNames;                            // Setting for short tab page names
        string[] tabNames = new string[2];                                              // Array for save menu short/long tab names text [0] for short, [1] for long

        List<string> folders = Settings.Default.fontFolders.Cast<string>().ToList();    // Setting for folder path
        PrivateFontCollection pfc;                                                      // Private font collection for storing the fonts of the currently open folder
        FontStyle fontStyle = 0;                                                        // Stores information about the font style (enum System.Drawing.FontStyle)
        int fontSize = 16;                                                              // Stores information about the font size

        FVPanel panel;                                                                  // Custom panel element used to display fonts
        #endregion

        #region INITIALIZE

        public MainWindow()
        {
            InitializeComponent();
            DeleteNonExistFolders();
            SetLocale(Settings.Default.locale);
            RestoreState();

            sizeSlider.Value = fontSize;
            sizeNumeric.Value = fontSize;
            textSample.TextChanged += textSample_TextChanged;
            sizeSlider.Scroll += sizeSlider_Scroll;
            sizeNumeric.ValueChanged += sizeNumeric_ValueChanged;
            colorButton.BackColor = Color.Black;
            bgcolorButton.BackColor = Color.White;
            
            for (int i = 0; i < pangram.Length / 2; i++)
                pangramComboBox.Items.Add(pangram[0, i]);

            foreach (string path in folders)
                CreateTabPage(path, false);
        }

        private void SetLocale(string locale)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(locale);
            LocaleManager lm = new LocaleManager();
            textSample.Text = lm.Get("textSample");
            boldButton.Text = lm.Get("boldSymbol");
            italicButton.Text = lm.Get("italicSymbol");
            underlineButton.Text = lm.Get("underlineSymbol");
            strikeoutButton.Text = lm.Get("strikeoutSymbol");
            menuFolders.Text = lm.Get("menuFolders");
            menuAddFolder.Text = lm.Get("menuAddFolder");
            menuAddWindowsFolder.Text = lm.Get("menuAddWindowsFolder");
            menuTabs.Text = lm.Get("menuTabs");
            menuTabNameLength.Text = shortTabNames ? lm.Get("menuLongTabNames") : lm.Get("menuShortTabNames");
            menuCloseAllTabs.Text = lm.Get("menuCloseAllTabs");
            menuLanguage.Text = lm.Get("menuLanguage");
            menuLanguageEnglish.Text = lm.Get("menuLanguageEnglish");
            menuLanguageRussian.Text = lm.Get("menuLanguageRussian");
            tabNames[0] = lm.Get("menuShortTabNames");
            tabNames[1] = lm.Get("menuLongTabNames");
        }

        #endregion

        #region WINDOW METHODS

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveState();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            WindowState = Settings.Default.windowState;
            Location = Settings.Default.windowLocation;
            Size = Settings.Default.windowSize;
        }

        private void RestoreState()
        {
            fontSize = Settings.Default.fontSize;
            fontStyle = Settings.Default.fontStyle;

            if (fontStyle.HasFlag(FontStyle.Bold)) fontStyleButtonSwitch(boldButton);
            if (fontStyle.HasFlag(FontStyle.Italic)) fontStyleButtonSwitch(italicButton);
            if (fontStyle.HasFlag(FontStyle.Underline)) fontStyleButtonSwitch(underlineButton);
            if (fontStyle.HasFlag(FontStyle.Strikeout)) fontStyleButtonSwitch(strikeoutButton);
        }

        private void SaveState()
        {
            Settings.Default.windowState = WindowState;

            if (WindowState == FormWindowState.Normal)
            {
                Settings.Default.windowLocation = Location;
                Settings.Default.windowSize = Size;
            }
            else
            {
                Settings.Default.windowLocation = RestoreBounds.Location;
                Settings.Default.windowSize = RestoreBounds.Size;
            }

            Settings.Default.fontSize = sizeSlider.Value;
            Settings.Default.fontStyle = fontStyle;

            Settings.Default.Save();
        }

        #endregion

        #region UPDATE METHODS

        private void UpdatePFC(string path)
        {
            pfc = new PrivateFontCollection();

            foreach (string fontPath in Directory.GetFiles(path).Where(file => allowedExtensions.Any(file.ToLower().EndsWith)))
                pfc.AddFontFile(fontPath);

            if (panel != null) panel.PFC = pfc;
        }

        private void UpdateSearch()
        {
            if (panel == null)
            {
                panel = new FVPanel(
                    pfc,
                    bgcolorButton.BackColor,
                    colorButton.BackColor,
                    textSample.Text,
                    new List<int>(),
                    fontStyle,
                    sizeSlider.Value);
            }
            List<int> tempSearchedItems = new List<int>();

            for (int i = 0; i < pfc.Families.Length; i++)
            {
                if (pfc.Families[i].Name.IndexOf(searchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0) // Instead of .Contains() because it is sensitive to the case
                {
                    tempSearchedItems.Add(i);
                }
            }
            countLabel.Text = Convert.ToString(tempSearchedItems.Count);
            panel.SearchedItems = tempSearchedItems;
        }

        private void UpdateAll(TabPage tabPage, int folderIndex)
        {
            UpdatePFC(folders[folderIndex]);
            UpdateSearch();
            tabPage.Controls.Add(panel);
        }

        #endregion

        #region TAB PAGE AND FOLDERS METHODS

        private void CreateTabPage(string name, bool select) // Create tab page and select it if select true
        {
            TabPage tabPage = new TabPage(shortTabNames ? GetShortName(name) : name);
            tabControl.TabPages.Add(tabPage);
            if (tabControl.TabCount == 1)
                UpdateAll(tabPage, 0);

            if (select)
                tabControl.SelectedTab = tabPage;
        }

        private void DeleteTabPage(int index) // Delete tab page and save changes in settings
        {
            countLabel.Text = "0";
            folders.RemoveAt(index);
            SaveFoldersInSettings();
            tabControl.TabPages.RemoveAt(index);
        }

        private void AddFolder(string path) // Add tab page with folder and save all folders in settings
        {
            if (!folders.Contains(path))
            {
                folders.Add(path);
                SaveFoldersInSettings();
                CreateTabPage(path, true);
            }
        }

        private void DeleteNonExistFolders() // Delete non-exist folders and save exist in settings
        {
            for (int i = folders.Count - 1; i >= 0; i--)
                if (!Directory.Exists(folders[i]))
                    folders.RemoveAt(i);
            SaveFoldersInSettings();
        }

        private void SaveFoldersInSettings() // Save folders in Settings.settings
        {
            StringCollection collection = new StringCollection();
            collection.AddRange(folders.ToArray());
            Settings.Default.fontFolders = collection;
            Settings.Default.Save();
        }

        #endregion

        #region AUXILIARY METHODS

        private string GetShortName(string s) // Return folder name from path
        {
            return new DirectoryInfo(s).Name;
        }

        private void fontStyleButtonSwitch(Button button)
        {
            if (button.Tag.ToString() == "Unpressed")
            {
                button.BackColor = Color.LightGray;
                button.Tag = "Pressed";
            }
            else
            {
                button.BackColor = Color.White;
                button.Tag = "Unpressed";
            }
        }

        private void fontStyleButtonPress(Button button, int number)
        {
            if (button.Tag.ToString() == "Unpressed")
            {
                fontStyle += number;
                fontStyleButtonSwitch(button);
            }
            else
            {
                fontStyle -= number;
                fontStyleButtonSwitch(button); ;
            }
            if (panel != null) panel.FontStyle = fontStyle;
        }

        #endregion

        #region CONTROL EVENTS

        private void sizeSlider_Scroll(object sender, EventArgs e)
        {
            sizeNumeric.Value = sizeSlider.Value;
            if (panel != null) panel.FontSize = sizeSlider.Value;

        }

        private void sizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            sizeSlider.Value = (int)sizeNumeric.Value;
            if (panel != null) panel.FontSize = sizeSlider.Value;
        }

        private void textSample_TextChanged(object sender, EventArgs e)
        {
            if (panel != null) panel.TextSample = textSample.Text;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (panel != null) UpdateSearch();
        }

        private void pangramComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pangramComboBox.SelectedIndex >= 0)
            {
                textSample.Text = pangram[1, pangramComboBox.SelectedIndex];
                pangramComboBox.SelectedIndex = -1;
            }
        }

        #endregion

        #region BUTTON EVENTS

        private void colorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorButton.BackColor = colorDialog.Color;
            if (panel != null) panel.TextColor = colorDialog.Color;
        }

        private void bgcolorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            bgcolorButton.BackColor = colorDialog.Color;
            if (panel != null) panel.BackgroundColor = colorDialog.Color;
        }

        private void clearSearchBox_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            fontStyleButtonPress(boldButton, 1);
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            fontStyleButtonPress(italicButton, 2);
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            fontStyleButtonPress(underlineButton, 4);
        }

        private void strikeoutButton_Click(object sender, EventArgs e)
        {
            fontStyleButtonPress(strikeoutButton, 8);
        }

        #endregion

        #region TAB CONTROL EVENTS

        private void tabControl_MouseUp(object sender, MouseEventArgs e) // Right click on tab close it
        {
            if (e.Button == MouseButtons.Right)
                for (int i = 0; i < tabControl.TabCount; i++)
                    if (tabControl.GetTabRect(i).Contains(e.Location))
                        DeleteTabPage(i);
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex >= 0 && folders.Count > 0)
                UpdateAll(e.TabPage, e.TabPageIndex);

        }

        private void tabControl_Deselected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex > -1)
                e.TabPage.Controls.RemoveByKey("fvpanel");
        }

        #endregion

        #region MENU EVENTS
        private void menuAddFolder_Click(object sender, EventArgs e)
        {
            if (addFolderDialog.ShowDialog() == DialogResult.OK)
                AddFolder(addFolderDialog.SelectedPath);
        }

        private void menuAddWindowsFolder_Click(object sender, EventArgs e)
        {
            AddFolder(Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
        }

        private void menuTabNameLength_Click(object sender, EventArgs e)
        {
            if (shortTabNames)
            {
                menuTabNameLength.Text = tabNames[0];
                for (int i = 0; i < folders.Count; i++)
                    tabControl.TabPages[i].Text = (folders[i]);
                shortTabNames = false;
            }
            else
            {
                menuTabNameLength.Text = tabNames[1];
                for (int i = 0; i < folders.Count; i++)
                    tabControl.TabPages[i].Text = GetShortName(folders[i]);
                shortTabNames = true;
            }
            Settings.Default.shortTabNames = shortTabNames;
            Settings.Default.Save();
        }

        private void menuCloseAllTabs_Click(object sender, EventArgs e)
        {
            for (int i = tabControl.TabPages.Count - 1; i >= 0; i--)
                DeleteTabPage(i);
        }

        private void menuLanguageEnglish_Click(object sender, EventArgs e)
        {
            SetLocale("en");
            Settings.Default.locale = "en";
            Settings.Default.Save();
        }

        private void menuLanguageRussian_Click(object sender, EventArgs e)
        {
            SetLocale("ru");
            Settings.Default.locale = "ru";
            Settings.Default.Save();
        }

        #endregion
    }
}
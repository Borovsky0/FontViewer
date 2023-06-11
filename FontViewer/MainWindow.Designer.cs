namespace FontViewer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.sizeSlider = new System.Windows.Forms.TrackBar();
            this.textSample = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorButton = new System.Windows.Forms.Button();
            this.sizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.bgcolorButton = new System.Windows.Forms.Button();
            this.menuDialog = new System.Windows.Forms.MainMenu(this.components);
            this.menuFolders = new System.Windows.Forms.MenuItem();
            this.menuAddFolder = new System.Windows.Forms.MenuItem();
            this.menuAddWindowsFolder = new System.Windows.Forms.MenuItem();
            this.menuTabs = new System.Windows.Forms.MenuItem();
            this.menuTabNameLength = new System.Windows.Forms.MenuItem();
            this.menuCloseAllTabs = new System.Windows.Forms.MenuItem();
            this.menuLanguage = new System.Windows.Forms.MenuItem();
            this.menuLanguageEnglish = new System.Windows.Forms.MenuItem();
            this.menuLanguageRussian = new System.Windows.Forms.MenuItem();
            this.addFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.pangramComboBox = new System.Windows.Forms.ComboBox();
            this.boldButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.underlineButton = new System.Windows.Forms.Button();
            this.strikeoutButton = new System.Windows.Forms.Button();
            this.clearSearchBox = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sizeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(18, 75);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1542, 601);
            this.tabControl.TabIndex = 2;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            this.tabControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseUp);
            // 
            // sizeSlider
            // 
            this.sizeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeSlider.AutoSize = false;
            this.sizeSlider.Location = new System.Drawing.Point(18, 689);
            this.sizeSlider.Margin = new System.Windows.Forms.Padding(6);
            this.sizeSlider.Maximum = 120;
            this.sizeSlider.Minimum = 5;
            this.sizeSlider.Name = "sizeSlider";
            this.sizeSlider.Size = new System.Drawing.Size(1382, 45);
            this.sizeSlider.TabIndex = 3;
            this.sizeSlider.TickFrequency = 0;
            this.sizeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sizeSlider.Value = 5;
            // 
            // textSample
            // 
            this.textSample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSample.BackColor = System.Drawing.Color.White;
            this.textSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSample.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSample.Location = new System.Drawing.Point(18, 746);
            this.textSample.Margin = new System.Windows.Forms.Padding(6);
            this.textSample.Name = "textSample";
            this.textSample.Size = new System.Drawing.Size(1152, 43);
            this.textSample.TabIndex = 4;
            this.textSample.Text = "textSample";
            // 
            // colorButton
            // 
            this.colorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.colorButton.BackColor = System.Drawing.Color.White;
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorButton.Location = new System.Drawing.Point(1515, 746);
            this.colorButton.Margin = new System.Windows.Forms.Padding(6);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(45, 45);
            this.colorButton.TabIndex = 99;
            this.colorButton.TabStop = false;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // sizeNumeric
            // 
            this.sizeNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeNumeric.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeNumeric.Location = new System.Drawing.Point(1412, 689);
            this.sizeNumeric.Margin = new System.Windows.Forms.Padding(6);
            this.sizeNumeric.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.sizeNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sizeNumeric.Name = "sizeNumeric";
            this.sizeNumeric.Size = new System.Drawing.Size(90, 43);
            this.sizeNumeric.TabIndex = 99;
            this.sizeNumeric.TabStop = false;
            this.sizeNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // bgcolorButton
            // 
            this.bgcolorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bgcolorButton.BackColor = System.Drawing.Color.White;
            this.bgcolorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgcolorButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bgcolorButton.Location = new System.Drawing.Point(1515, 689);
            this.bgcolorButton.Margin = new System.Windows.Forms.Padding(6);
            this.bgcolorButton.Name = "bgcolorButton";
            this.bgcolorButton.Size = new System.Drawing.Size(45, 45);
            this.bgcolorButton.TabIndex = 99;
            this.bgcolorButton.TabStop = false;
            this.bgcolorButton.UseVisualStyleBackColor = false;
            this.bgcolorButton.Click += new System.EventHandler(this.bgcolorButton_Click);
            // 
            // menuDialog
            // 
            this.menuDialog.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFolders,
            this.menuTabs,
            this.menuLanguage});
            // 
            // menuFolders
            // 
            this.menuFolders.Index = 0;
            this.menuFolders.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuAddFolder,
            this.menuAddWindowsFolder});
            this.menuFolders.Text = "folders";
            // 
            // menuAddFolder
            // 
            this.menuAddFolder.Index = 0;
            this.menuAddFolder.Text = "addFolder";
            this.menuAddFolder.Click += new System.EventHandler(this.menuAddFolder_Click);
            // 
            // menuAddWindowsFolder
            // 
            this.menuAddWindowsFolder.Index = 1;
            this.menuAddWindowsFolder.Text = "addWindowsFolder";
            this.menuAddWindowsFolder.Click += new System.EventHandler(this.menuAddWindowsFolder_Click);
            // 
            // menuTabs
            // 
            this.menuTabs.Index = 1;
            this.menuTabs.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuTabNameLength,
            this.menuCloseAllTabs});
            this.menuTabs.Text = "tabs";
            // 
            // menuTabNameLength
            // 
            this.menuTabNameLength.Index = 0;
            this.menuTabNameLength.Text = "shortTabNames";
            this.menuTabNameLength.Click += new System.EventHandler(this.menuTabNameLength_Click);
            // 
            // menuCloseAllTabs
            // 
            this.menuCloseAllTabs.Index = 1;
            this.menuCloseAllTabs.Text = "closeAllTabs";
            this.menuCloseAllTabs.Click += new System.EventHandler(this.menuCloseAllTabs_Click);
            // 
            // menuLanguage
            // 
            this.menuLanguage.Index = 2;
            this.menuLanguage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuLanguageEnglish,
            this.menuLanguageRussian});
            this.menuLanguage.Text = "language";
            // 
            // menuLanguageEnglish
            // 
            this.menuLanguageEnglish.Index = 0;
            this.menuLanguageEnglish.Text = "english";
            this.menuLanguageEnglish.Click += new System.EventHandler(this.menuLanguageEnglish_Click);
            // 
            // menuLanguageRussian
            // 
            this.menuLanguageRussian.Index = 1;
            this.menuLanguageRussian.Text = "russian";
            this.menuLanguageRussian.Click += new System.EventHandler(this.menuLanguageRussian_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(18, 18);
            this.searchBox.Margin = new System.Windows.Forms.Padding(6);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1387, 43);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // pangramComboBox
            // 
            this.pangramComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pangramComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.pangramComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pangramComboBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pangramComboBox.FormattingEnabled = true;
            this.pangramComboBox.Location = new System.Drawing.Point(1412, 745);
            this.pangramComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.pangramComboBox.Name = "pangramComboBox";
            this.pangramComboBox.Size = new System.Drawing.Size(89, 45);
            this.pangramComboBox.TabIndex = 9;
            this.pangramComboBox.SelectedIndexChanged += new System.EventHandler(this.pangramComboBox_SelectedIndexChanged);
            // 
            // boldButton
            // 
            this.boldButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boldButton.BackColor = System.Drawing.Color.White;
            this.boldButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.boldButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.boldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boldButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldButton.Location = new System.Drawing.Point(1182, 746);
            this.boldButton.Margin = new System.Windows.Forms.Padding(6);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(45, 45);
            this.boldButton.TabIndex = 5;
            this.boldButton.Tag = "Unpressed";
            this.boldButton.Text = "B";
            this.boldButton.UseVisualStyleBackColor = false;
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.italicButton.BackColor = System.Drawing.Color.White;
            this.italicButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.italicButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.italicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.italicButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.italicButton.Location = new System.Drawing.Point(1240, 746);
            this.italicButton.Margin = new System.Windows.Forms.Padding(6);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(45, 45);
            this.italicButton.TabIndex = 6;
            this.italicButton.Tag = "Unpressed";
            this.italicButton.Text = "I";
            this.italicButton.UseVisualStyleBackColor = false;
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.underlineButton.BackColor = System.Drawing.Color.White;
            this.underlineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.underlineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.underlineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underlineButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineButton.Location = new System.Drawing.Point(1298, 746);
            this.underlineButton.Margin = new System.Windows.Forms.Padding(6);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(45, 45);
            this.underlineButton.TabIndex = 7;
            this.underlineButton.Tag = "Unpressed";
            this.underlineButton.Text = "U";
            this.underlineButton.UseVisualStyleBackColor = false;
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // strikeoutButton
            // 
            this.strikeoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.strikeoutButton.BackColor = System.Drawing.Color.White;
            this.strikeoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.strikeoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.strikeoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strikeoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strikeoutButton.Location = new System.Drawing.Point(1355, 746);
            this.strikeoutButton.Margin = new System.Windows.Forms.Padding(6);
            this.strikeoutButton.Name = "strikeoutButton";
            this.strikeoutButton.Size = new System.Drawing.Size(45, 45);
            this.strikeoutButton.TabIndex = 8;
            this.strikeoutButton.Tag = "Unpressed";
            this.strikeoutButton.Text = "S";
            this.strikeoutButton.UseVisualStyleBackColor = false;
            this.strikeoutButton.Click += new System.EventHandler(this.strikeoutButton_Click);
            // 
            // clearSearchBox
            // 
            this.clearSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearSearchBox.BackColor = System.Drawing.Color.White;
            this.clearSearchBox.FlatAppearance.BorderSize = 0;
            this.clearSearchBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchBox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearSearchBox.Location = new System.Drawing.Point(1515, 18);
            this.clearSearchBox.Margin = new System.Windows.Forms.Padding(6);
            this.clearSearchBox.Name = "clearSearchBox";
            this.clearSearchBox.Size = new System.Drawing.Size(45, 45);
            this.clearSearchBox.TabIndex = 10;
            this.clearSearchBox.Text = "✕";
            this.clearSearchBox.UseVisualStyleBackColor = false;
            this.clearSearchBox.Click += new System.EventHandler(this.clearSearchBox_Click);
            // 
            // countLabel
            // 
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.Location = new System.Drawing.Point(1415, 18);
            this.countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(90, 45);
            this.countLabel.TabIndex = 100;
            this.countLabel.Text = "0";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1578, 809);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.clearSearchBox);
            this.Controls.Add(this.strikeoutButton);
            this.Controls.Add(this.underlineButton);
            this.Controls.Add(this.italicButton);
            this.Controls.Add(this.boldButton);
            this.Controls.Add(this.pangramComboBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.bgcolorButton);
            this.Controls.Add(this.sizeNumeric);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.textSample);
            this.Controls.Add(this.sizeSlider);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Menu = this.menuDialog;
            this.MinimumSize = new System.Drawing.Size(596, 436);
            this.Name = "MainWindow";
            this.Text = "FontViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TrackBar sizeSlider;
        private System.Windows.Forms.TextBox textSample;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.NumericUpDown sizeNumeric;
        private System.Windows.Forms.Button bgcolorButton;
        private System.Windows.Forms.MainMenu menuDialog;
        private System.Windows.Forms.MenuItem menuFolders;
        private System.Windows.Forms.MenuItem menuAddFolder;
        private System.Windows.Forms.FolderBrowserDialog addFolderDialog;
        private System.Windows.Forms.MenuItem menuTabs;
        private System.Windows.Forms.MenuItem menuAddWindowsFolder;
        private System.Windows.Forms.MenuItem menuTabNameLength;
        private System.Windows.Forms.MenuItem menuCloseAllTabs;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox pangramComboBox;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button italicButton;
        private System.Windows.Forms.Button underlineButton;
        private System.Windows.Forms.Button strikeoutButton;
        private System.Windows.Forms.Button clearSearchBox;
        private System.Windows.Forms.MenuItem menuLanguage;
        private System.Windows.Forms.MenuItem menuLanguageEnglish;
        private System.Windows.Forms.MenuItem menuLanguageRussian;
        private System.Windows.Forms.Label countLabel;
    }
}


using System.Drawing.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FontViewer
{
    public partial class FVPanel : Panel
    {
        private PrivateFontCollection pfc;
        private Color backgroundColor;
        private Color textColor;
        private string textSample;
        private List<int> searchedItems = new List<int>();
        private FontStyle fontStyle;
        private int fontSize;

        private int height;
        private int width;

        private int nameHeight = 35;
        private int widthCorrection = 30;

        public FVPanel(PrivateFontCollection PFC, Color BackgroundColor, Color TextColor, string TextSample, List<int> SearchedItems, FontStyle FontStyle, int FontSize)
        {
            Name = "fvpanel";
            AutoScroll = true;
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            BorderStyle = BorderStyle.None;
            SetStyle(ControlStyles.UserPaint, true);

            pfc = PFC;
            backgroundColor = BackgroundColor;
            textColor = TextColor;
            textSample = TextSample;
            searchedItems = SearchedItems;
            fontStyle = FontStyle;
            fontSize = FontSize;
        }

        public PrivateFontCollection PFC { set { pfc = value; } }

        public Color BackgroundColor { set { backgroundColor = value; Refresh(); } }

        public Color TextColor { set { textColor = value; Refresh(); } }

        public string TextSample { set { textSample = value; Refresh(); } }

        public List<int> SearchedItems { get { return searchedItems; } set { searchedItems = value; Refresh(); } }

        public FontStyle FontStyle { get { return fontStyle; } set { fontStyle = value; Refresh(); } }

        public int FontSize { set { fontSize = value; Refresh(); } }

        private Brush GetReadableBrush(Color c)
        {
            return (((c.R + c.B + c.G) / 3) > 128) ? Brushes.Black : Brushes.White;
        }

        void CalcSize()
        {
            width = fontSize * textSample.Length * 2; // Almost all letters fit in (2x3) * fontSize box
            height = fontSize * 3;
            if (width < Size.Width) width = Size.Width; 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            CalcSize();
            // widthCorrection is necessary because there is a horizontal scroll without the ability to move
            AutoScrollMinSize = new Size(width - widthCorrection, (height + nameHeight) * searchedItems.Count); 

            e.Graphics.FillRegion(new SolidBrush(backgroundColor), new Region(e.ClipRectangle));
            e.Graphics.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y); // Move graphics to scroll position
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            int yPos = 0;

            for (int i = 0; i < searchedItems.Count; i++)
            {
                // Draw font name
                e.Graphics.DrawString(pfc.Families[searchedItems[i]].Name,
                    new Font("Segoe UI", 16),
                    GetReadableBrush(backgroundColor),
                    new Rectangle(0, yPos, width, nameHeight),
                    new StringFormat(StringFormatFlags.NoWrap) { LineAlignment = StringAlignment.Center });
                yPos += nameHeight;

                // Draw text sample in all searched fonts
                e.Graphics.DrawString(textSample,
                    new Font(pfc.Families[searchedItems[i]],
                    fontSize,
                    (FontStyle)fontStyle),
                    new SolidBrush(textColor),
                    new Rectangle(0, yPos, width, height),
                    new StringFormat(StringFormatFlags.NoWrap) { LineAlignment = StringAlignment.Center });
                yPos += height;

                // Separation line
                e.Graphics.DrawLine(Pens.DarkGray, 0, yPos, width, yPos);
            }
        }
    }
}

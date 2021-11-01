using System;
using System.Drawing;
using System.Windows.Forms;

namespace SampleSearchSQLite
{
    internal class CustomProgressBar : ProgressBar
    {
        /// <summary>
        /// Hold the text Alignment in ProgressBar
        /// </summary>
        public System.Drawing.ContentAlignment TextAlignment { get; set; }

        /// <summary>
        /// Hold the text Font
        /// </summary>
        public System.Drawing.Font TextFont { get; set; }

        /// <summary>
        /// Hold the text color
        /// </summary>
        public System.Drawing.Color TextColor { get; set; }

        /// <summary>
        /// Ширина отступов текста внутри контрола
        /// </summary>
        public System.Drawing.Point TextMargin { get; set; }

        public System.Drawing.SolidBrush MainColor { get; set; }

        public CustomProgressBar()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer
                    | ControlStyles.UserPaint
                    | ControlStyles.AllPaintingInWmPaint
                    , true);
            TextAlignment = ContentAlignment.MiddleCenter;
            TextFont = new Font("Verdana", 12, FontStyle.Bold);
            TextColor = System.Drawing.SystemColors.ControlText;
            TextMargin = new Point(1, 1);
            MainColor = new SolidBrush(Color.FromArgb(89, 146, 209));
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.Browsable(false)]
        public override string Text { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = ClientRectangle;
            Graphics g = e.Graphics;

            ProgressBarRenderer.DrawHorizontalBar(g, rect);
            if (Value > 0)
            {
                Rectangle clip = new(rect.X, rect.Y, (int)Math.Round(((float)Value / Maximum) * rect.Width), rect.Height);
                //ProgressBarRenderer.DrawHorizontalChunks(g, clip);
                if (MainColor == null)
                {
                    MainColor = new SolidBrush(Color.FromArgb(89, 146, 209));
                }
                e.Graphics.FillRectangle(MainColor, clip);
            }
            if (Text != "")
            {
                g.DrawString(Text, TextFont, new SolidBrush(TextColor), GetLocation(g));
            }
        }

        private Point GetLocation(Graphics _g)
        {
            if (TextAlignment != ContentAlignment.TopLeft)
            {
                SizeF sizeText = _g.MeasureString(Text, TextFont);
                switch (TextAlignment)
                {
                    case ContentAlignment.TopCenter: return new Point(Convert.ToInt32((Width / 2) - sizeText.Width / 2), TextMargin.Y);
                    case ContentAlignment.TopRight: return new Point(Convert.ToInt32(Width - sizeText.Width - TextMargin.X), TextMargin.Y);

                    case ContentAlignment.MiddleLeft: return new Point(TextMargin.X, Convert.ToInt32((Height / 2) - sizeText.Height / 2));
                    case ContentAlignment.MiddleCenter: return new Point(Convert.ToInt32((Width / 2) - sizeText.Width / 2), Convert.ToInt32((Height / 2) - sizeText.Height / 2));
                    case ContentAlignment.MiddleRight: return new Point(Convert.ToInt32(Width - sizeText.Width - TextMargin.X), Convert.ToInt32((Height / 2) - sizeText.Height / 2));

                    case ContentAlignment.BottomLeft: return new Point(TextMargin.X, Convert.ToInt32(Height - sizeText.Height - TextMargin.Y));
                    case ContentAlignment.BottomCenter: return new Point(Convert.ToInt32((Width / 2) - sizeText.Width / 2), Convert.ToInt32(Height - sizeText.Height - TextMargin.Y));
                    case ContentAlignment.BottomRight: return new Point(Convert.ToInt32(Width - sizeText.Width - TextMargin.X), Convert.ToInt32(Height - sizeText.Height - TextMargin.Y));
                }
            }
            return TextMargin;
        }
    }
}
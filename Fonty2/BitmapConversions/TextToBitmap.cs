using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BitmapConversions
{
    public class TextToBitmap
    {
        public string Input = "";
        public Font InputFont = new Font("Arial", 20);

        public Color BmpForeground = Color.Black;
        public Color BmpBackground = Color.White;

        private Image bmpText;
        public TextToBitmap()
        {

        }
        public TextToBitmap(string input, Font inputFont, Color bmpForeground, Color bmpBackground)
        {
            this.Input = input;
            this.InputFont = inputFont;
            this.BmpForeground = bmpForeground;
            this.BmpBackground = bmpBackground;
        }
        public Bitmap getBitmap()
        {
            bmpText = new Bitmap(1, 1);
            try
            {
                Graphics g = Graphics.FromImage(bmpText);
                SizeF inputSize = g.MeasureString(Input, InputFont);

                bmpText = new Bitmap(Convert.ToInt32(inputSize.Width),
                    Convert.ToInt32(inputSize.Height));
                g = Graphics.FromImage(bmpText);
                g.FillRectangle(new Pen(BmpBackground).Brush,
                    new Rectangle(0, 0, Convert.ToInt32(inputSize.Width), Convert.ToInt32(inputSize.Height)));
                g.DrawString(Input, InputFont, new Pen(BmpForeground).Brush, new PointF(0, 0));
            }
            catch
            {
                Graphics.FromImage(bmpText).FillRectangle(new Pen(BmpBackground).Brush, 
                    new Rectangle(0, 0, 1, 1));
            }
            return (Bitmap)bmpText;
        }
        public override string ToString()
        {
            return Input;
        }
    }
}

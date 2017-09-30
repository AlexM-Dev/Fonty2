using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BitmapConversions
{
    public class BitmapToAscii
    {
        public int RgbThreshold = 700; // rgb.R + rgb.G + rgb.B - maximum output is 765.
        public string StrFont = "0"; // The character representing the font 'black' colours.
        public string StrBackground = " "; // The character representing the background.
        public Bitmap BmpInput = new Bitmap(1, 1);
        public BitmapToAscii()
        {

        }
        public BitmapToAscii(Bitmap bmpInput, int rgbThreshold, string strFont, string strBackground)
        {
            this.BmpInput = bmpInput;
            this.RgbThreshold = rgbThreshold;
            this.StrFont = strFont;
            this.StrBackground = strBackground;
        }
        public string getAscii()
        {
            StringBuilder inputConverted = new StringBuilder();
            LockBitmap lockBitmap = new LockBitmap(BmpInput);
            lockBitmap.LockBits();
            for (int y = 0; y < lockBitmap.Height; y++)
            {
                for (int x = 0; x < lockBitmap.Width; x++)
                {
                    Color pixel = lockBitmap.GetPixel(x, y);
                    int pixelValue = pixel.R + pixel.G + pixel.B;

                    if (pixelValue <= RgbThreshold)
                    {
                        inputConverted.Append(StrFont);
                    }
                    else
                    {
                        inputConverted.Append(StrBackground);
                    }
                }
                inputConverted.Append(Environment.NewLine);
            }
            return inputConverted.ToString();
        }
        public void printAscii(ConsoleColor foregroundFont = ConsoleColor.White,
            ConsoleColor backgroundFont = ConsoleColor.Black,
            ConsoleColor foregroundBack = ConsoleColor.White,
            ConsoleColor backgroundBack = ConsoleColor.Black)
        {
            LockBitmap lockBitmap = new LockBitmap(BmpInput);
            lockBitmap.LockBits();
            for (int y = 0; y < lockBitmap.Height; y++)
            {
                for (int x = 0; x < lockBitmap.Width; x++)
                {
                    Color pixel = lockBitmap.GetPixel(x, y);
                    int pixelValue = pixel.R + pixel.G + pixel.B;

                    Console.SetCursorPosition(x, y);
                    if (pixelValue <= RgbThreshold)
                    {
                        Console.BackgroundColor = backgroundFont;
                        Console.ForegroundColor = foregroundFont;
                        Console.Write(StrFont);
                    }
                    else
                    {
                        Console.BackgroundColor = backgroundBack;
                        Console.ForegroundColor = foregroundBack;
                        Console.Write(StrBackground);
                    }
                }
            }
            lockBitmap.UnlockBits();
        }
    }
}
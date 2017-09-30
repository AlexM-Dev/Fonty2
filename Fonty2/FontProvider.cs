using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Fonty2
{
    // Class for managing installed and private fonts.
    // Author: Allyxs/iProgramIt.
    [Serializable]
    class FontProvider
    {
        // A complete list of fonts including that of the private ones.
        public List<string> Fonts = new List<string>();

        private List<FontFamily> installedFonts = new List<FontFamily>();
        private List<FontFamily> privateFonts = new List<FontFamily>();
        public FontProvider()
        {
            foreach (FontFamily f in new InstalledFontCollection().Families)
            {
                if (f.Name != "")
                {
                    Fonts.Add(f.Name);
                    installedFonts.Add(f);
                }
            }
        }
        public FontFamily GetFamily(string fontFamily)
        {
            if (Fonts.Contains(fontFamily))
            {
                foreach (FontFamily f in installedFonts)
                {
                    if (f.Name == fontFamily)
                    {
                        return f;
                    }
                }
                foreach (FontFamily f in privateFonts)
                {
                    if (f.Name == fontFamily)
                    {
                        return f;
                    }
                }
            }
            return null;
        }

        // Load a font.
        public void AddFont(string fileName)
        {
            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile(fileName);
            privateFonts.Add(font.Families[0]);
            Fonts.Add(font.Families[0].Name);
        }
        public void AddFont(FontFamily fontFamily)
        {
            privateFonts.Add(fontFamily);
        }

        // Remove a font.
        public void RemoveFont(string fontName)
        {
            FontFamily f = new FontFamily("");
            foreach (FontFamily font in privateFonts)
            {
                if (font.Name == fontName) { f = font; }
            }
            privateFonts.Remove(f);
            Fonts.Remove(f.Name);
        }
        public void RemoveFont(FontFamily fontFamily)
        {
            privateFonts.Remove(fontFamily);
            Fonts.Remove(fontFamily.Name);
        }

        // Filter through fonts from filter.
        public List<string> Filter(string filter)
        {
            List<string> fonts = new List<string>();
            foreach (string f in Fonts)
            {
                // Case insensitive search.
                if (f.ToLower().Contains(filter.ToLower()))
                {
                    fonts.Add(f);
                }
            }
            return fonts;
        }
    }
}
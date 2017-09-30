using System;
using System.Windows.Forms;
using BitmapConversions;
using System.Drawing.Text;
using System.Drawing;
using System.IO;

namespace Fonty2
{
    public partial class frmMain : Form
    {
        // Core converters + objects.
        frmOutput outputWindow = new frmOutput();
        TextToBitmap bitmapWriter;
        BitmapToAscii asciiWriter;

        // Defines what colours we should use for the console output.
        ConsoleColor fontForeground = ConsoleColor.White;
        ConsoleColor fontBackground = ConsoleColor.Black;
        ConsoleColor backForeground = ConsoleColor.White;
        ConsoleColor backBackground = ConsoleColor.Black;


        FontProvider fm = new FontProvider();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Loading fonts.
            string fontDir = Application.StartupPath + "\\Fonts";
            if (Directory.Exists(fontDir))
            {
                foreach (string font in Directory.GetFiles(fontDir))
                {
                    if (font.ToLower().EndsWith(".ttf"))
                    {
                        fm.AddFont(font);
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(fontDir);
            }
            lstFonts.Items.AddRange(fm.Fonts.ToArray());

            // Select default font (index of 0: every [working] computer has at least 1 font).
            lstFonts.SelectedIndexChanged -= lstFonts_SelectedIndexChanged;
            lstFonts.SelectedIndex = 0;
            lstFonts.SelectedIndexChanged += lstFonts_SelectedIndexChanged;

            // Creating our bitmap writer.
            bitmapWriter = new TextToBitmap(txtTextToWrite.Text,
                new Font(lstFonts.SelectedItem.ToString(), (int)nudSize.Value),
                Color.Black, Color.White);
            txtTextToWrite.Font = bitmapWriter.InputFont;

            // Fancy opacity changer :o
            this.Activated += delegate
            {
                this.Opacity = 1;
            };
            this.Deactivate += delegate
            {
                this.Opacity = 0.5;
            };

            outputWindow.Show();
        }

        // Handlers for updating the font (when changed by user).
        private void lstFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFont(lstFonts.SelectedItem.ToString(), (int)nudSize.Value);
            if (chkAutoUpdate.Checked)
            {
                if (rdbGetAscii.Checked)
                {
                    btnPrintToOutputWindow.PerformClick();
                }
                else
                {
                    btnPrintToConsole.PerformClick();
                }
            }
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            updateFont(lstFonts.SelectedItem.ToString(), (int)nudSize.Value);
        }

        // Methods for updating miscellaneous data.
        private void updateFont(string family, int size)
        {
            Font font = new Font(fm.GetFamily(family), size);

            txtTextToWrite.Font = font;
            bitmapWriter.InputFont = font;
        }
        private void updateAsciiWriter()
        {
            bitmapWriter.Input = txtTextToWrite.Text;
            asciiWriter = new BitmapToAscii(bitmapWriter.getBitmap(),
                700, txtFontChar.Text, txtBackChar.Text);
        }

        // Event handler for handling the change of mode (get/print).
        private void ModeChanged(object sender, EventArgs e)
        {
            gpbPrintAsciiCustomisation.Visible = rdbPrintAscii.Checked;
            btnPrintToConsole.Enabled = rdbPrintAscii.Checked;

            outputWindow.Visible = rdbGetAscii.Checked;
            btnPrintToOutputWindow.Enabled = rdbGetAscii.Checked;
            if (rdbPrintAscii.Checked)
            {
                NativeMethods.AllocConsole();
            }
            else
            {
                NativeMethods.FreeConsole();
            }
        }

        // Event handlers for exporting ASCII as a file.
        private void btnExportTXT_Click(object sender, EventArgs e)
        {
            updateAsciiWriter();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Export ASCII text to a text file.";
                sfd.Filter = "Text Files (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, asciiWriter.getAscii());
                }
            }
        }

        private void btnExportPNG_Click(object sender, EventArgs e)
        {
            updateAsciiWriter();
            Font f = outputWindow.txtOutput.Font;
            Color fColor = outputWindow.txtOutput.ForeColor;
            Color bColor = outputWindow.txtOutput.BackColor;
            TextToBitmap asciiTTB = new TextToBitmap(asciiWriter.getAscii(),
                new Font(f.FontFamily, f.Size, f.Style), fColor, bColor);
            Bitmap b = asciiTTB.getBitmap();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Export ASCII text to PNG.";
                sfd.Filter = "PNG (*.png)|*.png";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    b.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        // Event handler for handling the colour changing (printAscii mode).
        private void printAscii_ColorChangeClick(object sender, EventArgs e)
        {
            using (ConsoleColorDialog ccd = new ConsoleColorDialog())
            {
                Button b = (Button)sender;
                if (ccd.ShowDialog() == DialogResult.OK)
                {
                    switch (b.Name)
                    {
                        case "btnFontForeground":
                            fontForeground = ccd.SelectedColor;
                            break;
                        case "btnFontBackground":
                            fontBackground = ccd.SelectedColor;
                            break;
                        case "btnBackForeground":
                            backForeground = ccd.SelectedColor;
                            break;
                        case "btnBackBackground":
                            backBackground = ccd.SelectedColor;
                            break;
                    }
                }
            }
        }

        // Event handlers for outputting ASCII.
        private void btnPrintToOutputWindow_Click(object sender, EventArgs e)
        {
            updateAsciiWriter();
            outputWindow.txtOutput.Text = asciiWriter.getAscii();
        }
        private void btnPrintToConsole_Click(object sender, EventArgs e)
        {
            updateAsciiWriter();
            Console.Clear();
            asciiWriter.printAscii(fontForeground, fontBackground, backForeground, backBackground);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtTextToWrite_TextChanged(object sender, EventArgs e)
        {
            if (chkAutoUpdate.Checked)
            {
                if (rdbGetAscii.Checked)
                {
                    btnPrintToOutputWindow.PerformClick();
                }
                else
                {
                    btnPrintToConsole.PerformClick();
                }
            }
        }
        // Filter for listbox.
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            lstFonts.Items.Clear();
            lstFonts.Items.AddRange(fm.Filter(txtFilter.Text).ToArray());
        }
    }
}
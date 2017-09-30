namespace Fonty2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblFonts = new System.Windows.Forms.Label();
            this.lstFonts = new System.Windows.Forms.ListBox();
            this.txtTextToWrite = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblMode = new System.Windows.Forms.Label();
            this.rdbGetAscii = new System.Windows.Forms.RadioButton();
            this.rdbPrintAscii = new System.Windows.Forms.RadioButton();
            this.btnPrintToConsole = new System.Windows.Forms.Button();
            this.btnPrintToOutputWindow = new System.Windows.Forms.Button();
            this.gpbPrintAsciiCustomisation = new System.Windows.Forms.GroupBox();
            this.btnBackBackground = new System.Windows.Forms.Button();
            this.btnBackForeground = new System.Windows.Forms.Button();
            this.btnFontBackground = new System.Windows.Forms.Button();
            this.btnFontForeground = new System.Windows.Forms.Button();
            this.lblFontChar = new System.Windows.Forms.Label();
            this.txtFontChar = new System.Windows.Forms.TextBox();
            this.txtBackChar = new System.Windows.Forms.TextBox();
            this.lblBackChar = new System.Windows.Forms.Label();
            this.btnExportTXT = new System.Windows.Forms.Button();
            this.btnExportPNG = new System.Windows.Forms.Button();
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.tbcSettings = new System.Windows.Forms.TabControl();
            this.tabFont = new System.Windows.Forms.TabPage();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.pnlMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.gpbPrintAsciiCustomisation.SuspendLayout();
            this.tbcSettings.SuspendLayout();
            this.tabFont.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFonts
            // 
            this.lblFonts.AutoSize = true;
            this.lblFonts.Location = new System.Drawing.Point(14, 13);
            this.lblFonts.Name = "lblFonts";
            this.lblFonts.Size = new System.Drawing.Size(82, 13);
            this.lblFonts.TabIndex = 0;
            this.lblFonts.Text = "Installed Fonts:";
            // 
            // lstFonts
            // 
            this.lstFonts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstFonts.FormattingEnabled = true;
            this.lstFonts.Location = new System.Drawing.Point(17, 29);
            this.lstFonts.Name = "lstFonts";
            this.lstFonts.Size = new System.Drawing.Size(173, 173);
            this.lstFonts.TabIndex = 1;
            this.lstFonts.SelectedIndexChanged += new System.EventHandler(this.lstFonts_SelectedIndexChanged);
            // 
            // txtTextToWrite
            // 
            this.txtTextToWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextToWrite.Font = new System.Drawing.Font("Tahoma", 24F);
            this.txtTextToWrite.Location = new System.Drawing.Point(0, 0);
            this.txtTextToWrite.Multiline = true;
            this.txtTextToWrite.Name = "txtTextToWrite";
            this.txtTextToWrite.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTextToWrite.Size = new System.Drawing.Size(437, 241);
            this.txtTextToWrite.TabIndex = 3;
            this.txtTextToWrite.WordWrap = false;
            this.txtTextToWrite.TextChanged += new System.EventHandler(this.txtTextToWrite_TextChanged);
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(14, 229);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size:";
            // 
            // nudSize
            // 
            this.nudSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudSize.Location = new System.Drawing.Point(131, 227);
            this.nudSize.Maximum = new decimal(new int[] {
            25565,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(59, 20);
            this.nudSize.TabIndex = 5;
            this.nudSize.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(15, 13);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(66, 13);
            this.lblMode.TabIndex = 6;
            this.lblMode.Text = "Write mode:";
            // 
            // rdbGetAscii
            // 
            this.rdbGetAscii.AutoSize = true;
            this.rdbGetAscii.Checked = true;
            this.rdbGetAscii.Location = new System.Drawing.Point(18, 29);
            this.rdbGetAscii.Name = "rdbGetAscii";
            this.rdbGetAscii.Size = new System.Drawing.Size(74, 17);
            this.rdbGetAscii.TabIndex = 7;
            this.rdbGetAscii.TabStop = true;
            this.rdbGetAscii.Text = "getAscii();";
            this.rdbGetAscii.UseVisualStyleBackColor = true;
            this.rdbGetAscii.CheckedChanged += new System.EventHandler(this.ModeChanged);
            // 
            // rdbPrintAscii
            // 
            this.rdbPrintAscii.AutoSize = true;
            this.rdbPrintAscii.Location = new System.Drawing.Point(95, 29);
            this.rdbPrintAscii.Name = "rdbPrintAscii";
            this.rdbPrintAscii.Size = new System.Drawing.Size(80, 17);
            this.rdbPrintAscii.TabIndex = 8;
            this.rdbPrintAscii.Text = "printAscii();";
            this.rdbPrintAscii.UseVisualStyleBackColor = true;
            this.rdbPrintAscii.Visible = false;
            this.rdbPrintAscii.CheckedChanged += new System.EventHandler(this.ModeChanged);
            // 
            // btnPrintToConsole
            // 
            this.btnPrintToConsole.Enabled = false;
            this.btnPrintToConsole.Location = new System.Drawing.Point(310, 3);
            this.btnPrintToConsole.Name = "btnPrintToConsole";
            this.btnPrintToConsole.Size = new System.Drawing.Size(90, 40);
            this.btnPrintToConsole.TabIndex = 10;
            this.btnPrintToConsole.Text = "Print to Console";
            this.btnPrintToConsole.UseVisualStyleBackColor = true;
            this.btnPrintToConsole.Click += new System.EventHandler(this.btnPrintToConsole_Click);
            // 
            // btnPrintToOutputWindow
            // 
            this.btnPrintToOutputWindow.Location = new System.Drawing.Point(219, 3);
            this.btnPrintToOutputWindow.Name = "btnPrintToOutputWindow";
            this.btnPrintToOutputWindow.Size = new System.Drawing.Size(90, 40);
            this.btnPrintToOutputWindow.TabIndex = 11;
            this.btnPrintToOutputWindow.Text = "Print to Output Window";
            this.btnPrintToOutputWindow.UseVisualStyleBackColor = true;
            this.btnPrintToOutputWindow.Click += new System.EventHandler(this.btnPrintToOutputWindow_Click);
            // 
            // gpbPrintAsciiCustomisation
            // 
            this.gpbPrintAsciiCustomisation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbPrintAsciiCustomisation.Controls.Add(this.btnBackBackground);
            this.gpbPrintAsciiCustomisation.Controls.Add(this.btnBackForeground);
            this.gpbPrintAsciiCustomisation.Controls.Add(this.btnFontBackground);
            this.gpbPrintAsciiCustomisation.Controls.Add(this.btnFontForeground);
            this.gpbPrintAsciiCustomisation.Location = new System.Drawing.Point(18, 52);
            this.gpbPrintAsciiCustomisation.Name = "gpbPrintAsciiCustomisation";
            this.gpbPrintAsciiCustomisation.Size = new System.Drawing.Size(171, 124);
            this.gpbPrintAsciiCustomisation.TabIndex = 13;
            this.gpbPrintAsciiCustomisation.TabStop = false;
            this.gpbPrintAsciiCustomisation.Text = "printAscii() Customisation";
            this.gpbPrintAsciiCustomisation.Visible = false;
            // 
            // btnBackBackground
            // 
            this.btnBackBackground.Location = new System.Drawing.Point(85, 62);
            this.btnBackBackground.Name = "btnBackBackground";
            this.btnBackBackground.Size = new System.Drawing.Size(75, 38);
            this.btnBackBackground.TabIndex = 3;
            this.btnBackBackground.Text = "Back Background";
            this.btnBackBackground.UseVisualStyleBackColor = true;
            this.btnBackBackground.Click += new System.EventHandler(this.printAscii_ColorChangeClick);
            // 
            // btnBackForeground
            // 
            this.btnBackForeground.Location = new System.Drawing.Point(85, 24);
            this.btnBackForeground.Name = "btnBackForeground";
            this.btnBackForeground.Size = new System.Drawing.Size(75, 38);
            this.btnBackForeground.TabIndex = 2;
            this.btnBackForeground.Text = "Back Foreground";
            this.btnBackForeground.UseVisualStyleBackColor = true;
            this.btnBackForeground.Click += new System.EventHandler(this.printAscii_ColorChangeClick);
            // 
            // btnFontBackground
            // 
            this.btnFontBackground.Location = new System.Drawing.Point(10, 62);
            this.btnFontBackground.Name = "btnFontBackground";
            this.btnFontBackground.Size = new System.Drawing.Size(75, 38);
            this.btnFontBackground.TabIndex = 1;
            this.btnFontBackground.Text = "Font Background";
            this.btnFontBackground.UseVisualStyleBackColor = true;
            this.btnFontBackground.Click += new System.EventHandler(this.printAscii_ColorChangeClick);
            // 
            // btnFontForeground
            // 
            this.btnFontForeground.Location = new System.Drawing.Point(10, 24);
            this.btnFontForeground.Name = "btnFontForeground";
            this.btnFontForeground.Size = new System.Drawing.Size(75, 38);
            this.btnFontForeground.TabIndex = 0;
            this.btnFontForeground.Text = "Font Foreground";
            this.btnFontForeground.UseVisualStyleBackColor = true;
            this.btnFontForeground.Click += new System.EventHandler(this.printAscii_ColorChangeClick);
            // 
            // lblFontChar
            // 
            this.lblFontChar.AutoSize = true;
            this.lblFontChar.Location = new System.Drawing.Point(15, 179);
            this.lblFontChar.Name = "lblFontChar";
            this.lblFontChar.Size = new System.Drawing.Size(84, 13);
            this.lblFontChar.TabIndex = 14;
            this.lblFontChar.Text = "Font Character:";
            // 
            // txtFontChar
            // 
            this.txtFontChar.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.txtFontChar.Location = new System.Drawing.Point(105, 178);
            this.txtFontChar.MaxLength = 1;
            this.txtFontChar.Name = "txtFontChar";
            this.txtFontChar.Size = new System.Drawing.Size(84, 18);
            this.txtFontChar.TabIndex = 15;
            this.txtFontChar.Text = "0";
            // 
            // txtBackChar
            // 
            this.txtBackChar.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.txtBackChar.Location = new System.Drawing.Point(105, 198);
            this.txtBackChar.MaxLength = 1;
            this.txtBackChar.Name = "txtBackChar";
            this.txtBackChar.Size = new System.Drawing.Size(84, 18);
            this.txtBackChar.TabIndex = 17;
            this.txtBackChar.Text = " ";
            // 
            // lblBackChar
            // 
            this.lblBackChar.AutoSize = true;
            this.lblBackChar.Location = new System.Drawing.Point(15, 199);
            this.lblBackChar.Name = "lblBackChar";
            this.lblBackChar.Size = new System.Drawing.Size(84, 13);
            this.lblBackChar.TabIndex = 16;
            this.lblBackChar.Text = "Back Character:";
            // 
            // btnExportTXT
            // 
            this.btnExportTXT.Location = new System.Drawing.Point(37, 3);
            this.btnExportTXT.Name = "btnExportTXT";
            this.btnExportTXT.Size = new System.Drawing.Size(90, 40);
            this.btnExportTXT.TabIndex = 18;
            this.btnExportTXT.Text = "Export to TXT File";
            this.btnExportTXT.UseVisualStyleBackColor = true;
            this.btnExportTXT.Click += new System.EventHandler(this.btnExportTXT_Click);
            // 
            // btnExportPNG
            // 
            this.btnExportPNG.Location = new System.Drawing.Point(128, 3);
            this.btnExportPNG.Name = "btnExportPNG";
            this.btnExportPNG.Size = new System.Drawing.Size(90, 40);
            this.btnExportPNG.TabIndex = 19;
            this.btnExportPNG.Text = "Export to PNG Image";
            this.btnExportPNG.UseVisualStyleBackColor = true;
            this.btnExportPNG.Click += new System.EventHandler(this.btnExportPNG_Click);
            // 
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.AutoSize = true;
            this.chkAutoUpdate.Location = new System.Drawing.Point(42, 222);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(131, 17);
            this.chkAutoUpdate.TabIndex = 20;
            this.chkAutoUpdate.Text = "Automatically Refresh";
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(14, 208);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(35, 13);
            this.lblFilter.TabIndex = 21;
            this.lblFilter.Text = "Filter:";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilter.Location = new System.Drawing.Point(55, 205);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(135, 20);
            this.txtFilter.TabIndex = 22;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // tbcSettings
            // 
            this.tbcSettings.Controls.Add(this.tabFont);
            this.tbcSettings.Controls.Add(this.tabOptions);
            this.tbcSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbcSettings.Location = new System.Drawing.Point(437, 0);
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            this.tbcSettings.Size = new System.Drawing.Size(213, 286);
            this.tbcSettings.TabIndex = 23;
            // 
            // tabFont
            // 
            this.tabFont.Controls.Add(this.lblFonts);
            this.tabFont.Controls.Add(this.txtFilter);
            this.tabFont.Controls.Add(this.lstFonts);
            this.tabFont.Controls.Add(this.lblFilter);
            this.tabFont.Controls.Add(this.nudSize);
            this.tabFont.Controls.Add(this.lblSize);
            this.tabFont.Location = new System.Drawing.Point(4, 22);
            this.tabFont.Name = "tabFont";
            this.tabFont.Padding = new System.Windows.Forms.Padding(3);
            this.tabFont.Size = new System.Drawing.Size(205, 260);
            this.tabFont.TabIndex = 0;
            this.tabFont.Text = "Font";
            this.tabFont.UseVisualStyleBackColor = true;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.lblMode);
            this.tabOptions.Controls.Add(this.chkAutoUpdate);
            this.tabOptions.Controls.Add(this.rdbGetAscii);
            this.tabOptions.Controls.Add(this.rdbPrintAscii);
            this.tabOptions.Controls.Add(this.gpbPrintAsciiCustomisation);
            this.tabOptions.Controls.Add(this.lblFontChar);
            this.tabOptions.Controls.Add(this.txtFontChar);
            this.tabOptions.Controls.Add(this.lblBackChar);
            this.tabOptions.Controls.Add(this.txtBackChar);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(205, 260);
            this.tabOptions.TabIndex = 2;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnExportTXT);
            this.pnlMenu.Controls.Add(this.btnPrintToOutputWindow);
            this.pnlMenu.Controls.Add(this.btnExportPNG);
            this.pnlMenu.Controls.Add(this.btnPrintToConsole);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMenu.Location = new System.Drawing.Point(0, 241);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(437, 45);
            this.pnlMenu.TabIndex = 24;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 286);
            this.Controls.Add(this.txtTextToWrite);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.tbcSettings);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(666, 325);
            this.MinimumSize = new System.Drawing.Size(666, 325);
            this.Name = "frmMain";
            this.Text = "Fonty2";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.gpbPrintAsciiCustomisation.ResumeLayout(false);
            this.tbcSettings.ResumeLayout(false);
            this.tabFont.ResumeLayout(false);
            this.tabFont.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFonts;
        private System.Windows.Forms.ListBox lstFonts;
        private System.Windows.Forms.TextBox txtTextToWrite;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.RadioButton rdbGetAscii;
        private System.Windows.Forms.RadioButton rdbPrintAscii;
        private System.Windows.Forms.Button btnPrintToConsole;
        private System.Windows.Forms.Button btnPrintToOutputWindow;
        private System.Windows.Forms.GroupBox gpbPrintAsciiCustomisation;
        private System.Windows.Forms.Label lblFontChar;
        private System.Windows.Forms.TextBox txtFontChar;
        private System.Windows.Forms.TextBox txtBackChar;
        private System.Windows.Forms.Label lblBackChar;
        private System.Windows.Forms.Button btnBackBackground;
        private System.Windows.Forms.Button btnBackForeground;
        private System.Windows.Forms.Button btnFontBackground;
        private System.Windows.Forms.Button btnFontForeground;
        private System.Windows.Forms.Button btnExportTXT;
        private System.Windows.Forms.Button btnExportPNG;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TabControl tbcSettings;
        private System.Windows.Forms.TabPage tabFont;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.Panel pnlMenu;
    }
}


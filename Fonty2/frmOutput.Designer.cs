namespace Fonty2
{
    partial class frmOutput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutput));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.mnuOptions = new System.Windows.Forms.MainMenu(this.components);
            this.mnuColour = new System.Windows.Forms.MenuItem();
            this.itmTextColour = new System.Windows.Forms.MenuItem();
            this.itmBackgroundColour = new System.Windows.Forms.MenuItem();
            this.itmShrink = new System.Windows.Forms.MenuItem();
            this.itmExpand = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.Black;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.txtOutput.ForeColor = System.Drawing.Color.White;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(484, 361);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "The output will appear here.";
            this.txtOutput.WordWrap = false;
            // 
            // mnuOptions
            // 
            this.mnuOptions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuColour,
            this.itmShrink,
            this.itmExpand});
            // 
            // mnuColour
            // 
            this.mnuColour.Index = 0;
            this.mnuColour.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.itmTextColour,
            this.itmBackgroundColour});
            this.mnuColour.Text = "Colour";
            // 
            // itmTextColour
            // 
            this.itmTextColour.Index = 0;
            this.itmTextColour.Text = "Text";
            this.itmTextColour.Click += new System.EventHandler(this.itmTextColour_Click);
            // 
            // itmBackgroundColour
            // 
            this.itmBackgroundColour.Index = 1;
            this.itmBackgroundColour.Text = "Background";
            this.itmBackgroundColour.Click += new System.EventHandler(this.itmBackgroundColour_Click);
            // 
            // itmShrink
            // 
            this.itmShrink.Index = 1;
            this.itmShrink.Shortcut = System.Windows.Forms.Shortcut.Ins;
            this.itmShrink.Text = "(-)";
            this.itmShrink.Click += new System.EventHandler(this.itmShrink_Click);
            // 
            // itmExpand
            // 
            this.itmExpand.Index = 2;
            this.itmExpand.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.itmExpand.Text = "(+)";
            this.itmExpand.Click += new System.EventHandler(this.itmExpand_Click);
            // 
            // frmOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.txtOutput);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mnuOptions;
            this.Name = "frmOutput";
            this.Text = "Output | [INS] to Shrink | [DEL] to Enlarge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOutput_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.MainMenu mnuOptions;
        private System.Windows.Forms.MenuItem itmShrink;
        private System.Windows.Forms.MenuItem itmExpand;
        private System.Windows.Forms.MenuItem mnuColour;
        private System.Windows.Forms.MenuItem itmTextColour;
        private System.Windows.Forms.MenuItem itmBackgroundColour;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fonty2
{
    public partial class frmOutput : Form
    {
        public frmOutput()
        {
            InitializeComponent();
        }

        private void itmExpand_Click(object sender, EventArgs e)
        {
            modifySize(1);
        }
        private void itmShrink_Click(object sender, EventArgs e)
        {
            modifySize(-1);
        }

        private void modifySize(int modifier)
        {
            Font f = txtOutput.Font;
            txtOutput.Font = new Font(f.FontFamily, f.Size + modifier, f.Style);
        }

        private void itmTextColour_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.Color = txtOutput.ForeColor;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    txtOutput.ForeColor = cd.Color;
                }
            }
        }

        private void itmBackgroundColour_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.Color = txtOutput.BackColor;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    txtOutput.BackColor = cd.Color;
                }
            }
        }

        private void frmOutput_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class ConsoleColorDialog : Form
    {
        public ConsoleColor SelectedColor { get; set; }

        public ConsoleColorDialog()
        {
            InitializeComponent();
        }

        private void ConsoleColorDialog_Load(object sender, EventArgs e)
        {
            cbxSelectedColor.DataSource = Enum.GetValues(typeof(ConsoleColor));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ConsoleColor SelectedColor;
            Enum.TryParse(cbxSelectedColor.SelectedValue.ToString(),
                out SelectedColor);
            this.SelectedColor = SelectedColor;
        }
    }
}
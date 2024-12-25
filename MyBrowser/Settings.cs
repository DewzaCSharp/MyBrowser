using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace MyBrowser
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.CheckState == CheckState.Checked)
            {
                Form1.GenZMode = true;
            }
            else if (guna2CheckBox1.CheckState == CheckState.Unchecked)
            {
                Form1.GenZMode = false;
            }
        }
    }
}

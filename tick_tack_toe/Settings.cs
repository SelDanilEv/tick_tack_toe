using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tick_tack_toe
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            textmaxscore.Clear();
        }

        private void butsettingsok_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void checkmaxscore_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                ClassSettings.cbsettings = true;
            }
            else
            {
                ClassSettings.cbsettings = false;
            }
        }

        private void textmaxscore_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            ClassSettings.maxvalue = number - 48;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}

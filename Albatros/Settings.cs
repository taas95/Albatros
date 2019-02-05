using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albatros
{
    public partial class Settings : Form
    {
        
        public Settings()
        {
            InitializeComponent();
            label1.Font = Properties.Settings.Default.CurrentFont;

        }

        private void ToggleTheme_CheckedChanged(object sender)
        {

            //Color getcurrentColor = Properties.Settings.Default.CurrentColor;
            //if (getcurrentColor==Color.White)
            //{
            //    //Set dark mode
            //    Properties.Settings.Default.CurrentColor = Color.Black;
            //    Properties.Settings.Default.Save();
            //    Application.Restart();
            //}
            //else
            //{
            //    //Set Light mode
            //    Properties.Settings.Default.CurrentColor = Color.White;
            //    Properties.Settings.Default.Save();
            //    Application.Restart();
            //}
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

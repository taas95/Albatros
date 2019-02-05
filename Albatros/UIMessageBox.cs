using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albatros
{
    public partial class UIMessageBox : UserControl
    {
        AlbatrosUIColor appcolor = new AlbatrosUIColor();
        public UIMessageBox()
        {
            InitializeComponent();
        }



        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.BackColor = AlbatrosUIColor.DarkPrimary;
            tableLayoutPanel1.BackColor = AlbatrosUIColor.DarkPrimary;
            //this.BackColor = Properties.Settings.Default.CurrentColor;
            //tableLayoutPanel1.BackColor = Properties.Settings.Default.CurrentColor;
            //Properties.Settings.Default.Save();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Form currentForm = this.Parent as Form;
            currentForm.Hide();
            loginForm.Show();
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

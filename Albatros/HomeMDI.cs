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
    public partial class HomeMDI : Form
    {
        private int childFormNumber = 0;
        AfrForm afrForm = new AfrForm();
        StatisticsForm statisticsForm = new StatisticsForm();
        AlbatrosUi ui = new AlbatrosUi();
        SchedulingForm schedulingForm = new SchedulingForm();
        Settings Settings = new Settings();

        public HomeMDI()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //afrForm.Show();
            //uiMessageBox1.Hide();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listeToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            afrForm.MdiParent = this;
            //try
            //{
            //    afrForm.BringToFront();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    afrForm.Show();
            //}
            ui.openChild(afrForm);
            afrForm.Dock = DockStyle.Fill;
        }

        private void flightScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statisticsForm.MdiParent = this;

            ui.openChild(statisticsForm);
            statisticsForm.Dock = DockStyle.Fill;



        }

        private void menuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
        }

        private void menuStrip_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        int Mx;
        int My;
        int Sw;
        int Sh;

        bool mov;


        #region Make windows resizable
        //private const int cGrip = 16;
        //private const int cCaption = 32;

        //protected override void WndProc(ref Message m)
        //{

        //    if (m.Msg == 0x84)
        //    {
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToClient(pos);
        //        if (pos.Y < cCaption)
        //        {
        //            m.Result = (IntPtr)2;
        //            return;
        //        }
        //        if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
        //        {
        //            m.Result = (IntPtr)17;
        //            return;
        //        }
        //    }

        //    base.WndProc(ref m);
        //}





        #endregion

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sizeMod_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }

        private void sizeMod_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                Width = MousePosition.X - Mx + Sw;
                Height = MousePosition.Y - My + Sh;
            }
        }

        private void sizeMod_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void quitterLapplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nouveauToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void openScheduleBtn_Click(object sender, EventArgs e)
        {
            //schedulingForm.Show();
            schedulingForm.MdiParent = this;
            //try
            //{
            //    afrForm.BringToFront();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    afrForm.Show();
            //}
            ui.openChild(schedulingForm);
            //schedulingForm.Dock = DockStyle.Top;

        }

        private void controlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
        }

        private void controlPanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            uiMessageBox1.BringToFront();
        }

        private void HomeMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
    //        const string message =
    //"Are you sure that you would like to close the App?";
    //        const string caption = "Form Closing";
    //        var result = MessageBox.Show(message, caption,
    //                                     MessageBoxButtons.YesNo,
    //                                     MessageBoxIcon.Question);

    //        // If the no button was pressed ...
    //        if (result == DialogResult.No)
    //        {
    //            // cancel the closure of the form.
    //            e.Cancel = true;
    //        }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            uiMessageBox1.Show();
        }

        private void HomeMDI_Load(object sender, EventArgs e)
        {
            uiMessageBox1.Hide();
            afrForm.MdiParent = this;
            ui.openChild(afrForm);
            afrForm.Dock = DockStyle.Fill;

        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            //Settings.Show();
        }

        private void uiMessageBox1_Load(object sender, EventArgs e)
        {

        }
    }
}

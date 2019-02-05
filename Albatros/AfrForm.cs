using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albatros
{
    public partial class AfrForm : Form
    {
        SQLiteManager sQLiteManager = new SQLiteManager();
        AlbatrosUi Ui = new AlbatrosUi();
        public AfrForm()
        {
            InitializeComponent();
            //this.BackColor = Properties.Settings.Default.CurrentColor;
            string getAirCraft = "select code from aircraft;";
            using (SQLiteCommand command = new SQLiteCommand(SQLiteManager.conSqlite))
            {
                SQLiteManager.conSqlite.Open();
                command.CommandText = getAirCraft;
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        airCraftTypeCbx.Items.Add(reader["code"]);
                    }
                }
                SQLiteManager.conSqlite.Close();

            }
            
        }

        private void AfrForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }
        #region Auto Focus
        private void piloteTbx_KeyDown(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                e.Handled = true;
                copiloteTbx.Focus();
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void copiloteTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                pnc1Tbx.Focus();
                e.SuppressKeyPress = true;

            }
        }

        private void pnc1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                pnc2Tbx.Focus();
                e.SuppressKeyPress = true;

            }
        }


        private void pnc2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                pnc3Tbx.Focus();
                e.SuppressKeyPress = true;

            }
        }

        private void pnc3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                pnc4Tbx.Focus();
                e.SuppressKeyPress = true;

            }
        }

        private void pnc4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                blockTimeOutTbx.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void blockTimeOutTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                blockTimeInTbx.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void blockTimeInTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                flightTimeOffTbx.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void flightTimeOffTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                flightTimeOnTbx.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void flightTimeOnTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                flightTimePlanTbx.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void flightTimePlanTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                grossActualTOTbx.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void grossActualTOTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                grossActualPlanTbx.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void grossActualPlanTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                fuelActualRampTbx.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void fuelActualRampTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                fuelActualToTbx.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void fuelActualToTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                fuelActualLdgTbx.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void fuelActualLdgTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                fuelPlanToTbx.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void fuelPlanToTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                fuelPlanLdgTbx.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void fuelPlanLdgTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                fuelAddedTbx.Focus();
                e.SuppressKeyPress = true;
            }
        }


        #endregion

        private void piloteTbx_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void piloteTbx_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void copiloteTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Tbxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        #region Validation of textboxes
        private void blockTimeOutTbx_OnValueChanged(object sender, EventArgs e)
        {

            int val = 0;
            if (blockTimeOutTbx.Text != "")
            {
                string timeFromTbx = blockTimeOutTbx.Text;
                blockTimeOutTbx.Text = Ui.CheckTime(timeFromTbx);
            }
            #region old method
            //try
            //{
            //    val = Convert.ToInt32(blockTimeOutTbx.Text);

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    if (ex.Message == "Le format de la chaîne d'entrée est incorrect.")
            //        throw;
            //}
            //string timeConverted;

            //if (val <=959 && val>0)
            //{
            //    if (val <= 59)
            //    {
            //        timeConverted = "00" + val;
            //        blockTimeOutTbx.Text = timeConverted;
            //    }
            //    else
            //    {
            //        timeConverted = "0" + val;

            //        char hour = timeConverted[1];
            //        char min = timeConverted[2];
            //        //int c = Convert.ToInt32(hour);

            //        if (Convert.ToInt16(hour.ToString()) <= 9)
            //        {
            //            if (Convert.ToInt32(min.ToString()) <= 5)
            //            {
            //                blockTimeOutTbx.Text = timeConverted;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Please enter a valid Minute " + min);
            //                Console.WriteLine(timeConverted);

            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please enter a valid Hour " + Convert.ToInt16(hour.ToString()));
            //            Console.WriteLine(timeConverted);

            //        }
            //    }

            //}
            //else if(val >959)
            //{
            //    timeConverted = val.ToString();
            //    char hour = timeConverted[0];
            //    char min = timeConverted[2];
            //    if (Convert.ToInt32(hour.ToString()) <= 2)
            //    {
            //        if(Convert.ToInt32(timeConverted[1].ToString())<=4)
            //        {
            //            if(Convert.ToInt32(min.ToString()) <=5)
            //            {
            //                if(Convert.ToInt32(timeConverted[3].ToString()) <=9)
            //                {
            //                    Console.WriteLine("Temps valide");
            //                    blockTimeOutTbx.Text = timeConverted;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Minute invalide");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Minute invalide");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Heure invalide");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Heure invalide");
            //    }
            //}
            #endregion

        }

        private void blockTimeInTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (blockTimeInTbx.Text != "")
            {
                string timeFromTbx = blockTimeInTbx.Text;
                blockTimeInTbx.Text = Ui.CheckTime(timeFromTbx);
                if (Ui.compTime(blockTimeOutTbx.Text, blockTimeInTbx.Text) == 1)
                {
                    blockTimeInTbx.ForeColor = Color.Red;
                    blockTimeOutTbx.ForeColor = Color.Red;
                    blockTimeInTbx.LineIdleColor = Color.Red;
                    blockTimeOutTbx.LineIdleColor = Color.Red;
                }
                else
                {
                    blockTimeInTbx.ForeColor = Color.FromArgb(64, 64, 64);
                    blockTimeOutTbx.ForeColor = Color.FromArgb(64, 64, 64);
                    blockTimeInTbx.LineIdleColor = Color.FromArgb(64, 64, 64);
                    blockTimeOutTbx.LineIdleColor = Color.FromArgb(64, 64, 64);

                }
            }
        }

        #endregion

        private void flightTimeOffTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (flightTimeOffTbx.Text != "")
            {
                string timeFromTbx = flightTimeOffTbx.Text;
                flightTimeOffTbx.Text = Ui.CheckTime(timeFromTbx);
            }
        }

        private void flightTimeOnTbx_OnValueChanged(object sender, EventArgs e)
        {
            if (flightTimeOnTbx.Text != "")
            {
                string timeFromTbx = flightTimeOnTbx.Text;
                flightTimeOnTbx.Text = Ui.CheckTime(timeFromTbx);
                if(Ui.compTime(flightTimeOffTbx.Text, flightTimeOnTbx.Text)==1)
                {
                    flightTimeOffTbx.ForeColor = Color.Red;
                    flightTimeOnTbx.ForeColor = Color.Red;
                    flightTimeOnTbx.LineIdleColor = Color.Red;
                    flightTimeOffTbx.LineIdleColor = Color.Red;

                }
                else
                {
                    flightTimeOffTbx.ForeColor = Color.FromArgb(64,64,64);
                    flightTimeOnTbx.ForeColor = Color.FromArgb(64, 64, 64);
                    flightTimeOffTbx.LineIdleColor = Color.FromArgb(64,64,64);
                    flightTimeOnTbx.LineIdleColor = Color.FromArgb(64, 64, 64);

                }
            }
        }

        private void flightTimePlanTbx_OnValueChanged(object sender, EventArgs e)
        {
            string timeFromTbx = flightTimePlanTbx.Text;
            flightTimePlanTbx.Text = Ui.CheckTime(timeFromTbx);
        }

        private void grossActualTOTbx_OnValueChanged(object sender, EventArgs e)
        {

            Ui.checkG(grossActualTOTbx);

        }

        private void grossActualPlanTbx_OnValueChanged(object sender, EventArgs e)
        {
            Ui.checkG(grossActualPlanTbx);
        }

        private void fuelActualRampTbx_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void fuelActualToTbx_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void fuelActualLdgTbx_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void fuelPlanToTbx_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void fuelPlanLdgTbx_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void fuelAddedTbx_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void airCraftTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(airCraftTypeCbx.Text.ToString());
            string value = airCraftTypeCbx.Text.ToString();
            if(value=="AQD" || value=="AQC" || value=="AQE"|| value=="AQF")
            {
                fuelActualRampTbx.Enabled = false;
                fuelActualToTbx.Enabled = false;
                fuelActualLdgTbx.Enabled = false;
            }
            else
            {
                fuelActualRampTbx.Enabled = true ;
                fuelActualToTbx.Enabled = true;
                fuelActualLdgTbx.Enabled = true;
            }
        }
    }
}

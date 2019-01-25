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
    public partial class AfrForm : Form
    {
        public AfrForm()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

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
    }
}

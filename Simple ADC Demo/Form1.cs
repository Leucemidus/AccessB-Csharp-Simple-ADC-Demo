using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_ADC_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AccessB AccB = new AccessB();//First declate the AccessB object

        //Find the device
        private void btnFindDev_Click(object sender, EventArgs e)
        {
            if (AccB.FindDevHID() == true)
            {
                lblStatus.Text = "Status: Connected";
                //Enabling all the buttons
                btnADCconfig.Enabled = true;
                btnADCOn.Enabled = true;
                btnSample.Enabled = true;
                btnADCOff.Enabled = true;
            }
            else
            {
                lblStatus.Text = "Status: Disconnected";
            }
        }
        
        //Configure ADC to use all it's analog inputs AN0 to AN12, AN5,6 and 7 don't exist on PIC18F2550
        private void btnADCconfig_Click(object sender, EventArgs e)
        {
            AccB.ADC_CFG(AccB.CFG_ADC_AS_Basic, AccB.ADC_AN0_To_12);
        }

        //Turn on ADC
        private void btnADCOn_Click(object sender, EventArgs e)
        {
            AccB.ADC_Enable(true);
        }

        //Turn Off ADC
        private void btnADCOff_Click(object sender, EventArgs e)
        {
            AccB.ADC_Enable(false);
        }

        //Obtain a sample from ADC for the selected channel in the combo box, Analog input 0 (AN0) is in the pin RA0 (pin number 2).
        //view the pin diagrams in the 18F2550 Datasheet to know where are the other analog inputs.
        private void btnSample_Click(object sender, EventArgs e)
        {
            if (cmbChannel.Text == "")
            {
                MessageBox.Show("Please select a valid analog input");
                return;
            }
            txbSampleVal.Text = AccB.ADC_Val(Convert.ToUInt32(cmbChannel.Text)).ToString();
        }

        //If the user want to write something that isn't in the combo box list it's deleted.
        private void cmbChannelBorrar_KeyUp(object sender, KeyEventArgs e)
        {
            cmbChannel.Text = "";
        }

    }
}

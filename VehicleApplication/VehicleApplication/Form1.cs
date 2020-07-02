using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApplication
{
    
    public partial class Form1 : Form
    {
 
        [System.ComponentModel.Browsable(false)]
        public Type ValidatingType { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void mskdBoxHour_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DateTime newDate;
            DateTime.TryParse(mskdBoxDate.Text, out newDate);
            DateTime time1;
            DateTime.TryParse(mskdBoxHour.Text, out time1);
            if (!mskdBoxDate.MaskFull || newDate.Year == 0001|| newDate.Month > 12 || newDate.Day > 31 || newDate > DateTime.Now.AddMonths(6)|| time1.Year == 0001)
            {
                MessageBox.Show("Please enter the correct Date error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
      
                return;
            }
            else
            {
                    listBox1.Items.Add("Route : " + cmbBoxFromW.Text + "-" +cmbBoxToWhere.Text + "     " + "Date : " + mskdBoxDate.Text + "     " +
                  "Hour : " + mskdBoxHour.Text);

                    listBox1.Items.Add("Name : " + txtBoxNameSurn.Text + "   " +"TC ID : " + mskdBoxTC.Text + "   " + "Phone:" + mskdBoxPhone.Text);
            }




        }

        
        private void btnChange_Click(object sender, EventArgs e)
        {
            lblChngCity.Text = cmbBoxFromW.Text;
            cmbBoxFromW.Text = cmbBoxToWhere.Text;
            cmbBoxToWhere.Text = lblChngCity.Text;
        }

        private void chckRoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            if(chckRoundTrip.Checked)
            {
                mskdReturnDate.Visible = true;
                mskdReturnHour.Visible = true;
                lblReturnDate.Visible = true;
                lblReturnDateHour.Visible = true;
                lblReturnHour.Visible = true;
                
            }
            else
            {
                mskdReturnDate.Visible = false;
                mskdReturnHour.Visible = false;
                lblReturnDate.Visible = false;
                lblReturnDateHour.Visible = false;
                lblReturnHour.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //private void mskdBoxDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        //{
        //  if(mskdBoxDate.MaskFull)
        //    {

        //    }

        //}
    }
}

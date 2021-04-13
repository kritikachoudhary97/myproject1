using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //Declaring the variables
        double billamt;
        double tippercent;
        int noofpeople;
        double tipamt;
        double tipamtperperson;
        double totbill;
        double billamtperperson;

        public Form1()
        {
            InitializeComponent();
        }

        private void people_txtbox_TextChanged(object sender, EventArgs e)
        {   //This calculates the tip person person and bill per person and displays it in the labels.
            try
            {
                billamt = Convert.ToDouble(bill_amttxtbox.Text);
                tippercent = Convert.ToDouble(tipcent_txtbox.Text);
                if ((people_txtbox.Text != "") || !(string.IsNullOrEmpty(people_txtbox.Text)))
                {
                    noofpeople = Convert.ToInt32(people_txtbox.Text);
                    tipamt = billamt * (tippercent / 100);
                    tipamtperperson = tipamt / noofpeople;
                    tipperperson_label.Text = tipamtperperson.ToString("N2");

                }
                else
                {
                    noofpeople = 0;

                }

                totbill = billamt + tipamt;
                billamtperperson = totbill / noofpeople;
                billperperson_label.Text = billamtperperson.ToString("N2");
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured: " + excp);
            }
        }

        private void bill_amttxtbox_Validating(object sender, CancelEventArgs e)
        {
            //Validates and checks if bill amount textbox is empty or 0,it gives a message box.
            try
            {
                if (bill_amttxtbox.Text == "" || bill_amttxtbox.Text == "0")
                {
                    MessageBox.Show("Please enter the bill amount");
                    bill_amttxtbox.Focus();
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured" + excp);
            }
        }

        private void tipcent_txtbox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (tipcent_txtbox.Text == "" || tipcent_txtbox.Text == "0")
                {
                    MessageBox.Show("Please enter the tip percentage");
                    tipcent_txtbox.Focus();
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured" + excp);
            }
        }

        private void people_txtbox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (tipcent_txtbox.Text == "" || people_txtbox.Text == "0")
                {
                    MessageBox.Show("Please enter the tip percentage");
                    people_txtbox.Focus();
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured" + excp);
            }
        }

        private void inctip_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double counttipinc = double.Parse(tipcent_txtbox.Text);
                counttipinc++;
                tipcent_txtbox.Text = counttipinc.ToString();
            }

            catch (Exception excp)
            {
                MessageBox.Show("Exception occured" + excp);
            }
        }


        private void dectip_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double counttipdec = double.Parse(tipcent_txtbox.Text);
                if (counttipdec >= 2)
                {
                    counttipdec--;
                    tipcent_txtbox.Text = counttipdec.ToString();
                }

                else
                {
                    MessageBox.Show("Values greater than 0 permitted!");
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured" + excp);
            }
        }

        private void peopleinc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int countpeopleinc = 0;
                if ((people_txtbox.Text != "") || !(string.IsNullOrEmpty(people_txtbox.Text)))
                {
                    countpeopleinc = int.Parse(people_txtbox.Text);
                    countpeopleinc++;
                    people_txtbox.Text = countpeopleinc.ToString();
                }
                else
                {
                    countpeopleinc++;
                    people_txtbox.Text = countpeopleinc.ToString();
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured" + excp);
            }
        }

        private void peopledec_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double countpeopledec = double.Parse(people_txtbox.Text);
                if (countpeopledec >= 2)
                {
                    countpeopledec--;
                    people_txtbox.Text = countpeopledec.ToString();
                }
                else
                {
                    MessageBox.Show("Values greater than 0 permitted!");
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured" + excp);
            }

        }

        private void bill_amttxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                char c = e.KeyChar;
                if (!char.IsDigit(c) && c != 8 && c != 46)
                {
                    e.Handled = true;
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured" + excp);
            }
        }

        private void tipcent_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                char c = e.KeyChar;
                if (!char.IsDigit(c) && c != 8 && c != 46)
                {
                    e.Handled = true;
                }
            }

            catch (Exception excp)
            {
                MessageBox.Show("Exception occured" + excp);
            }

        }

        private void people_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                char c = e.KeyChar;
                if (!char.IsDigit(c) && c != 8)
                {
                    e.Handled = true;
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception occured" + excp);
            }
        }

        private void tipcent_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if ((people_txtbox.Text != "") || !(string.IsNullOrEmpty(people_txtbox.Text)))
                {
                    billamt = Convert.ToDouble(bill_amttxtbox.Text);
                    tippercent = Convert.ToDouble(tipcent_txtbox.Text);
                    noofpeople = Convert.ToInt32(people_txtbox.Text);
                    tipamt = billamt * (tippercent / 100);
                    tipamtperperson = tipamt / noofpeople;
                    tipperperson_label.Text = tipamtperperson.ToString();

                }
                else
                {
                    tippercent = 0;

                }

                totbill = billamt + tipamt;
                billamtperperson = totbill / noofpeople;
                billperperson_label.Text = billamtperperson.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter tip percentage");
            }
        }
    }
}

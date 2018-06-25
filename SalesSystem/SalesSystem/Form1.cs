using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSystem
{
    public partial class SalesSystem : Form
    {
        decimal d_ShoesP = 40;
        decimal d_JacketsP = 50;
        decimal d_GlovesP = 15;
        decimal d_BeaniesP = 10;
        decimal d_SweatersP = 30;
        decimal d_ScarfsP = 20;

        decimal d_ShoesQ;
        decimal d_JacketsQ;
        decimal d_GlovesQ;
        decimal d_BeaniesQ;
        decimal d_SweatersQ;
        decimal d_ScarfsQ;

        decimal d_ShoesTotal;
        decimal d_JacketsTotal;
        decimal d_GlovesTotal;
        decimal d_BeaniesTotal;
        decimal d_SweatersTotal;
        decimal d_ScarfsTotal;

        decimal d_Total;

        public SalesSystem()
        {

            InitializeComponent();

            //The credit card info group is set to false
            grpCreditCardInfo.Enabled = false;

            //The unit price is set and unable to be altered 
            txtShoesP.Text = "$" + d_ShoesP.ToString();
            txtShoesP.Enabled = false;

            txtJacketsP.Text = "$" + d_JacketsP.ToString();
            txtJacketsP.Enabled = false;

            txtGlovesP.Text = "$" + d_GlovesP.ToString();
            txtGlovesP.Enabled = false;

            txtBeaniesP.Text = "$" + d_BeaniesP.ToString();
            txtBeaniesP.Enabled = false;

            txtSweatersP.Text = "$" + d_SweatersP.ToString();
            txtSweatersP.Enabled = false;

            txtScarfsP.Text = "$" + d_ScarfsP.ToString();
            txtScarfsP.Enabled = false;

            //The product quantities are set to false with a zero
            txtShoesQ.Enabled = false;
            txtShoesQ.Text = "0";

            txtJacketsQ.Enabled = false;
            txtJacketsQ.Text = "0";

            txtGlovesQ.Enabled = false;
            txtGlovesQ.Text = "0";

            txtBeaniesQ.Enabled = false;
            txtBeaniesQ.Text = "0";

            txtSweatersQ.Enabled = false;
            txtSweatersQ.Text = "0";

            txtScarfsQ.Enabled = false;
            txtScarfsQ.Text = "0";

            //The combo boxes have their values already loaded
            //Card Type combobox
            this.comCardType.Items.AddRange(new object[] 
            {"Visa",
             "Master Card",
             "Diners Club",
             "American Express"});

            //Expiry Month combobox
            this.comExpiryMonth.Items.AddRange(new object[] 
            {"January",
             "February",
             "March",
             "April",
             "May",
             "June",
             "July",
             "August",
             "September",
             "October",
             "November",
             "December"});

            //Issuing Bank combobox
            this.comIssuingBank.Items.AddRange(new object[]
            {"BNZ",
             "ANZ",
             "Kiwbank",
             "Westpac",
             "CBA"});

            //Dynamically adds ten years to the expiry year combobox
            int i_StartYear = DateTime.Now.Year;
            int i_ExpiryYear;

            for (i_ExpiryYear = i_StartYear; i_ExpiryYear <= i_StartYear + 10; i_ExpiryYear++)
            {
                comExpiryYear.Items.Add(i_ExpiryYear.ToString());
            }

            //Disables the total amount textbox so it can't be alterd
            txtTotalAmount.Enabled = false;
             
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        //What happens to the credit card info group when radio buttons are checked
        //Credit card radio button
        private void radCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (radCreditCard.Checked == true)
            {
                grpCreditCardInfo.Enabled = true;
            }

        }

        //Cash radio button
        private void radCash_CheckedChanged(object sender, EventArgs e)
        {
            if (radCash.Checked == true)
            {
                grpCreditCardInfo.Enabled = false;
                txtNameCard.Clear();
                comCardType.SelectedIndex = -1;
                txtCardNumber.Clear();
                comExpiryMonth.SelectedIndex = -1;
                comExpiryYear.SelectedIndex = -1;
                comIssuingBank.SelectedIndex = -1;
            }
        }

        //Bank Transfer radio button
        private void radBankTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (radBankTransfer.Checked == true)
            {
                grpCreditCardInfo.Enabled = false;
                txtNameCard.Clear();
                comCardType.SelectedIndex = -1;
                txtCardNumber.Clear();
                comExpiryMonth.SelectedIndex = -1;
                comExpiryYear.SelectedIndex = -1;
                comIssuingBank.SelectedIndex = -1;
            }


        }

        //When show summary button is pressed, meesage boxs may appear
        private void btnShowSummary_Click(object sender, EventArgs e)
        {
            //These four if statments must be accomplished before the customer details, credit card info and total amount message box will be displayed
            if ((((txtFirstName.Text == "") || (txtLastName.Text == "")) || (((Shoes.Checked == false) || (txtShoesQ.Text == "0")) && ((Jackets.Checked == false) || (txtJacketsQ.Text == "0")) && ((Gloves.Checked == false) || (txtGlovesQ.Text == "0")) && ((Beanies.Checked == false) || (txtBeaniesQ.Text == "0")) && ((Sweaters.Checked == false) || (txtSweatersQ.Text == "0")) && ((Scarfs.Checked == false) || (txtScarfsQ.Text == "0"))) || ((radBankTransfer.Checked == false) && (radCash.Checked == false) && (radCreditCard.Checked == false))))
            {
                //First Name
                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("First Name is required.");
                }

                //Last Name
                if (txtLastName.Text == "")
                {
                    MessageBox.Show("Last Name is required");
                }

                //Product Selection
                if (((Shoes.Checked == false) || (txtShoesQ.Text == "0")) && ((Jackets.Checked == false) || (txtJacketsQ.Text == "0")) && ((Gloves.Checked == false) || (txtGlovesQ.Text == "0")) && ((Beanies.Checked == false) || (txtBeaniesQ.Text == "0")) && ((Sweaters.Checked == false) || (txtSweatersQ.Text == "0")) && ((Scarfs.Checked == false) || (txtScarfsQ.Text == "0")))
                {
                    MessageBox.Show("A Product and Quantity is required.");
                }

                //Payment Type
                if ((radBankTransfer.Checked == false) && (radCash.Checked == false) && (radCreditCard.Checked == false))
                {
                    MessageBox.Show("Payment Type is required.");
                }
            }

            //Credit Card Info
            else if ((radCreditCard.Checked == true) && ((txtNameCard.Text == "") || (comCardType.Text == "") || (txtCardNumber.Text == "") || (comExpiryMonth.Text == "") || (comExpiryYear.Text == "") || (comIssuingBank.Text == "")))
            {
                MessageBox.Show("Credit Card Information required.");
            }

            //Shows customer details, credit card info and total amount
            else if (radCreditCard.Checked == true)
            {
                MessageBox.Show
                ("Customer Details:" + "".PadRight(4) + txtFirstName.Text + "".PadRight(4) + txtLastName.Text + "".PadRight(4) + txtStreetAddress.Text + "".PadRight(4) + txtSuburb.Text + "".PadRight(4) + txtCity.Text + "".PadRight(4) + txtCounty.Text +
                 Environment.NewLine + "Credit Card Information:" + "".PadRight(4) + txtNameCard.Text + "".PadRight(4) + comCardType.Text + "".PadRight(4) + txtCardNumber.Text + "".PadRight(4) + comExpiryMonth.Text + "".PadRight(4) + comExpiryYear.Text + "".PadRight(4) + comIssuingBank.Text +
                 Environment.NewLine + Environment.NewLine + "Total Amount is: $" + txtTotalAmount.Text);
            }

            //Instead shows customer details and total amount
            else
            {
                MessageBox.Show
                ("Customer Details:" + "".PadRight(4) + txtFirstName.Text + "".PadRight(4) + txtLastName.Text + "".PadRight(4) + txtStreetAddress.Text + "".PadRight(4) + txtSuburb.Text + "".PadRight(4) + txtCity.Text + "".PadRight(4) + txtCounty.Text +
                 Environment.NewLine + Environment.NewLine + "Total Amount is: $" + txtTotalAmount.Text);
            }
        }

        //When reset button is pressed the values in the boxes will clear 
        private void btnReset_Click(object sender, EventArgs e)
        { 
            //Customer details 
            txtFirstName.Clear();
            txtLastName.Clear();
            txtStreetAddress.Clear();
            txtSuburb.Clear();
            txtCity.Clear();
            txtCounty.Clear();

            //Credit card info 
            txtNameCard.Clear();
            comCardType.SelectedIndex = -1;
            txtCardNumber.Clear();
            comExpiryMonth.SelectedIndex = -1;
            comExpiryYear.SelectedIndex = -1;
            comIssuingBank.SelectedIndex = -1;
            grpCreditCardInfo.Enabled = false;

            //Product selection
            Shoes.Checked = false;
            txtShoesQ.Text = "0";

            Scarfs.Checked = false;
            txtScarfsQ.Text = "0";

            Sweaters.Checked = false;
            txtSweatersQ.Text = "0";

            Jackets.Checked = false;
            txtJacketsQ.Text = "0";

            Gloves.Checked = false;
            txtGlovesQ.Text = "0";

            Beanies.Checked = false;
            txtBeaniesQ.Text = "0";

            //Payment Type
            radCash.Checked = false;
            radCreditCard.Checked = false;
            radBankTransfer.Checked = false;

            //Total amount
            txtTotalAmount.Text = "0";
        }

        private void comCardType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Clicking the checkboxs enable the corresponding text boxes
        private void Shoes_CheckedChanged(object sender, EventArgs e)
        {
            if (Shoes.Checked == true)
            {
                txtShoesQ.Enabled = true;
            }
            else
            {
                txtShoesQ.Enabled = false;
            }

            if (Shoes.Checked == false)
            {
                txtShoesQ.Text = "0";
            }
        }

        private void Jackets_CheckedChanged(object sender, EventArgs e)
        {
            if (Jackets.Checked == true)
            {
                txtJacketsQ.Enabled = true;
            }
            else
            {
                txtJacketsQ.Enabled = false;
            }

            if (Jackets.Checked == false)
            {
                txtJacketsQ.Text = "0";
            }
        }

        private void Gloves_CheckedChanged(object sender, EventArgs e)
        {
            if (Gloves.Checked == true)
            {
                txtGlovesQ.Enabled = true;
            }
            else
            {
                txtGlovesQ.Enabled = false;
            }

            if (Gloves.Checked == false)
            {
                txtGlovesQ.Text = "0";
            }
        }

        private void Beanies_CheckedChanged(object sender, EventArgs e)
        {
            if (Beanies.Checked == true)
            {
                txtBeaniesQ.Enabled = true;
            }
            else
            {
                txtBeaniesQ.Enabled = false;
            }

            if (Beanies.Checked == false)
            {
                txtBeaniesQ.Text = "0";
            }
        }

        private void Sweaters_CheckedChanged(object sender, EventArgs e)
        {
            if (Sweaters.Checked == true)
            {
                txtSweatersQ.Enabled = true;
            }
            else
            {
                txtSweatersQ.Enabled = false;
            }

            if (Sweaters.Checked == false)
            {
                txtSweatersQ.Text = "0";
            }
        }

        private void Scarfs_CheckedChanged(object sender, EventArgs e)
        {
            if (Scarfs.Checked == true)
            {
                txtScarfsQ.Enabled = true;
            }
            else
            {
                txtScarfsQ.Enabled = false;
            }

            if (Scarfs.Checked == false)
            {
                txtScarfsQ.Text = "0";
            }
        }

        private void comExpiryYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //The product quantity text boxes will only accept numbers
        private void txtShoesQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtJacketsQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtGlovesQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtBeaniesQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtSweatersQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtScarfsQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtShoesP_TextChanged(object sender, EventArgs e)
        {
                    
        }

        //The formula to work out the total for each product
        private void txtShoesQ_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtShoesP.Text) && !string.IsNullOrEmpty(txtShoesQ.Text))
            {
                d_ShoesQ = Convert.ToDecimal(txtShoesQ.Text);
                d_ShoesTotal = d_ShoesP * d_ShoesQ;
                m_CalcTotal();
            }
        }

        private void txtJacketsQ_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtJacketsP.Text) && !string.IsNullOrEmpty(txtJacketsQ.Text))
            {
                d_JacketsQ = Convert.ToDecimal(txtJacketsQ.Text);
                d_JacketsTotal = d_JacketsP * d_JacketsQ;
                m_CalcTotal();
            }
        }

        private void txtGlovesQ_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGlovesP.Text) && !string.IsNullOrEmpty(txtGlovesQ.Text))
            {
                d_GlovesQ = Convert.ToDecimal(txtGlovesQ.Text);
                d_GlovesTotal = d_GlovesP * d_GlovesQ;
                m_CalcTotal();
            }
        }

        private void txtBeaniesQ_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBeaniesP.Text) && !string.IsNullOrEmpty(txtBeaniesQ.Text))
            {
                d_BeaniesQ = Convert.ToDecimal(txtBeaniesQ.Text);
                d_BeaniesTotal = d_BeaniesP * d_BeaniesQ;
                m_CalcTotal();
            }
        }

        private void txtSweatersQ_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSweatersP.Text) && !string.IsNullOrEmpty(txtSweatersQ.Text))
            {
                d_SweatersQ = Convert.ToDecimal(txtSweatersQ.Text);
                d_SweatersTotal = d_SweatersP * d_SweatersQ;
                m_CalcTotal();
            }
        }

        private void txtScarfsQ_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScarfsP.Text) && !string.IsNullOrEmpty(txtScarfsQ.Text))
            {
                d_ScarfsQ = Convert.ToDecimal(txtScarfsQ.Text);
                d_ScarfsTotal = d_ScarfsP * d_ScarfsQ;
                m_CalcTotal();
            }
        }

        //The formula for calculating the total amount 
        private void m_CalcTotal()
        {
            decimal d_Total;

            d_Total = d_BeaniesTotal + d_GlovesTotal + d_JacketsTotal + d_ScarfsTotal + d_ShoesTotal + d_SweatersTotal;

            txtTotalAmount.Text = d_Total.ToString();

            if (d_Total < 50)
            { radCreditCard.Enabled = false; }
            else
            { radCreditCard.Enabled = true; }

            if (d_Total < 50)
            { radCreditCard.Checked = false; }

            if (d_Total > 1500)
            { radCash.Enabled = false; }
            else
            { radCash.Enabled = true; }

            if (d_Total > 1500)
            { radCash.Checked = false; }

            if (txtTotalAmount.Text == "0")
            { grpCreditCardInfo.Enabled = false; }
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
   
        }
    }
}

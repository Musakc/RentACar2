using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class RentalScreen : Form
    {
        public RentalScreen()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbxConfirm.Checked != true)
            {
                cbxConfirm.ForeColor = Color.Red;
                lblWarningCardNumber.Text = "Eksik veya hatalı tuşlama yaptınız";
            }
            else
            {
                cbxConfirm.ForeColor = Color.Black;

            }
            if (tbxCardNumber.Text.Length != 16)
            {
                lblCardNumber.ForeColor = Color.Red;
                lblWarningCardNumber.Text = "Eksik veya hatalı tuşlama yaptınız";
            }
            else
                lblCardNumber.ForeColor = Color.Black;

            if (!cbxMonth.Items.Contains(cbxMonth.Text))
            {
                cbxMonth.ForeColor = Color.Red;
                lblWarningCardNumber.Text = "Eksik veya hatalı tuşlama yaptınız";
            }
            else
                cbxMonth.ForeColor = Color.Black;

            if (!cbxYear.Items.Contains(cbxYear.Text))
            {
                cbxYear.ForeColor = Color.Red;
                lblWarningCardNumber.Text = "Eksik veya hatalı tuşlama yaptınız";
            }
            else
                cbxYear.ForeColor = Color.Black;

            if (tbxPassword.Text.Length != 3)
            {
                lblPassword.ForeColor = Color.Red;
                lblWarningCardNumber.Text = "Eksik veya hatalı tuşlama yaptınız";
            }
            else
                lblPassword.ForeColor = Color.Black;


            if (cbxConfirm.ForeColor == Color.Black && lblCardNumber.ForeColor == Color.Black && cbxMonth.ForeColor == Color.Black && cbxYear.ForeColor == Color.Black && lblPassword.ForeColor == Color.Black)
            {
                lblWarningCardNumber.Text = "";
                MessageBox.Show("Sipraişiniz alınmıştır en kısa sürede arabanız kapıda olacaktır.");
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gbxCustomerInfo.Enabled == false)
            {
                gbxCustomerInfo.Enabled = true;
            }
        }

        private void tbxCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyDigit(sender, e);
        }

        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyDigit(sender, e);
        }

        private void tbxTCSales_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyDigit(sender, e);
        }

        private void tbxGSMSales_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyDigit(sender, e);
        }

        private void onlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

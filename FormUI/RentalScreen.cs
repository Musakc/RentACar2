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
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public SourceForm Source {  get; set; }  //hangi form'dan geçiş yaptığımızı belirtmek için

        public RentalScreen()
        {
            InitializeComponent();
        }

        private void RentalScreen_Load(object sender, EventArgs e)
        {
            // CarId değerini tbxCarIdSales textbox'ına yazdırın
            tbxCarIdSales.Text = CarId.ToString();
            tbxBrandSales.Text = Brand.ToString();
            tbxModelSales.Text = Model.ToString();

            // Hangi formdan geçiş yapıldığını kontrol ederek özel işlemler yapılabilir
            switch (Source)
            {
                case SourceForm.Form1:
                    // Form1'den geçiş yapıldıysa özel işlemler
                    break;
                case SourceForm.FavoritesScreen:
                    // FavoritesScreen'den geçiş yapıldıysa özel işlemler
                    break;
            }
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
                tbxCarIdSales.Enabled = false;
                tbxBrandSales.Enabled = false;
                tbxModelSales.Enabled = false;
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

        private void lblBrandData_Click(object sender, EventArgs e)
        {

        }

        
    }
}

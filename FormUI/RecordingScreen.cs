using Business.Abstract;
using Business.Concrete;
using Business.UserService;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class RecordingScreen : Form
    {
        public RecordingScreen()
        {
            InitializeComponent();
            _personService = new PersonManager(new EfPersonDal());
        }
        
        private PersonManager _personService;
        
        //static string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RentACar2;Integrated Security=True;";
        //SqlConnection connect = new SqlConnection(constring);
        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string password = tbxPasswordRC.Text;
            string confirmPassword = tbxConfirmPasswordRC.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(tbxUserNameRC.Text) ||
                     string.IsNullOrWhiteSpace(tbxPasswordRC.Text) ||
                     string.IsNullOrWhiteSpace(tbxConfirmPasswordRC.Text) ||
                     string.IsNullOrWhiteSpace(tbxPhoneNumberRC.Text) ||
                     string.IsNullOrWhiteSpace(tbxNameRC.Text) ||
                     string.IsNullOrWhiteSpace(tbxSurnameRC.Text) ||
                     string.IsNullOrWhiteSpace(tbxEmailRC.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string Email = tbxEmailRC.Text;


                if (!Email.EndsWith("@gmail.com") && !string.IsNullOrWhiteSpace(Email))
                {

                    MessageBox.Show("Lütfen geçerli bir Gmail e-posta adresi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Person newPerson = new Person
                {
                    UserName = tbxUserNameRC.Text,
                    Password = tbxPasswordRC.Text,
                    PhoneNumber = tbxPhoneNumberRC.Text,
                    Name = tbxNameRC.Text,
                    Surname = tbxSurnameRC.Text,
                    Email = tbxEmailRC.Text
                };

                _personService.Add(newPerson);
                MessageBox.Show("Kayıt eklendi");
                //this.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi: " + hata.Message);
            }
        }

        private void RecordingScreen_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbxUserNameRC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxUserNameRC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxNameRC_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNameRC_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void tbxSurnameRC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxPhoneNumberRC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool showPassword = chkShowPassword.Checked;
            tbxPasswordRC.UseSystemPasswordChar = !showPassword;
            tbxConfirmPasswordRC.UseSystemPasswordChar = !showPassword;
        }

        private void RecordingScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

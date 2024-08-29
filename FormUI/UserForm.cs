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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RecordingScreen screen = new RecordingScreen();
            screen.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            Form1 form1 = new Form1();
            form1.ShowDialog();
            /*
            using (SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RentACar;Integrated Security=True;"))
            {
                string query = "SELECT * FROM Persons WHERE Kullanıcı_Adı = @username AND Sifre = @password";
                using (SqlCommand com = new SqlCommand(query, con))
                {
                    com.Parameters.AddWithValue("@username", username);
                    com.Parameters.AddWithValue("@password", password);

                    con.Open();
                    using (SqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            
                            MessageBox.Show("Giriş başarılı");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                        }
                    }
                }
            }*/
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
                tbxPassword.UseSystemPasswordChar = false;
            else
                tbxPassword.UseSystemPasswordChar = true;
        }
    }
}

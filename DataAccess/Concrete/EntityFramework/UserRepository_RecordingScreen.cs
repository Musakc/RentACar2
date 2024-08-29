using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class UserRepository_RecordingScreen
    {
        private readonly string _connectionString;

        public UserRepository_RecordingScreen(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddUser(string username, string password, string confirmPassword, string phoneNumber, string firstName, string lastName)
        {
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                string query = "insert into bilgi (kullanici_adi,sifre,sifre_dogrulama,telefon,ad,soyad) values(@kullanici_adi,@sifre,@sifre_dogrulama,@telefon,@ad,@soyad)";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@kullanici_adi", username);
                command.Parameters.AddWithValue("@sifre", password);
                command.Parameters.AddWithValue("@sifre_dogrulama", confirmPassword);
                command.Parameters.AddWithValue("@telefon", phoneNumber);
                command.Parameters.AddWithValue("@ad", firstName);
                command.Parameters.AddWithValue("@soyad", lastName);

                connect.Open();
                command.ExecuteNonQuery();
            }
        }

        public bool ValidateUser(string username, string password)
        {
            bool isValid = false;

            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(1) FROM bilgi WHERE kullanici_adi = @kullanici_adi AND sifre = @sifre";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@kullanici_adi", username);
                command.Parameters.AddWithValue("@sifre", password);
                connect.Open();
                int count = (int)command.ExecuteScalar();
                isValid = count > 0;
            }

            return isValid;
        }
    }
}

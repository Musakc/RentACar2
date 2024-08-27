using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCar();
            
            //context.Database.Create();
        }

        private void ListCar()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Car.ToList();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                string Marka = dgwProduct.CurrentRow.Cells["Marka"].Value.ToString();
                string Model = dgwProduct.CurrentRow.Cells["Model"].Value.ToString();
                string Fiyat = dgwProduct.CurrentRow.Cells["Fiyat"].Value.ToString();
                //string carColor = dgwProduct.CurrentRow.Cells["CarColor"].Value.ToString();
                //string carFuel = dgwProduct.CurrentRow.Cells["CarFuel"].Value.ToString();
                //string carKM = dgwProduct.CurrentRow.Cells["CarKM"].Value.ToString();  //veri tabanında ekli değil


                lblBrandText.Text = Marka;
                lblModelText.Text = Model;
                lblUnitPriceText.Text = Fiyat;
                //lblColorText.Text = carColor;
                //lblFuelText.Text = carFuel;
                //lblKMText.Text = carKM;
            }
            else
            {
                MessageBox.Show("Lütfen bir araç seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnMyFavorites_Click(object sender, EventArgs e)
        {
            FavoritesScreen myFavorites = new FavoritesScreen();
            myFavorites.ShowDialog();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            RentalScreen screen = new RentalScreen();
            screen.ShowDialog();
        }

        private void tbxDay_TextChanged(object sender, EventArgs e)
        {
            if (lblPrice.Text == null)
            {
                lblPrice.Text = "";
            }
            else
            {
                decimal result = Convert.ToDecimal(dgwProduct.CurrentRow.Cells["Fiyat"].Value.ToString()) * int.Parse(tbxDay.Text);
                lblPrice.Text = result.ToString();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.ShowDialog();
        }

        private void btnAddFavorites_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Favorilerime eklendi.");
        }
    }
}


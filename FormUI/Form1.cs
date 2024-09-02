using Business.Abstract;
using Business.Concrete;
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
            _favoriteService = new FavoriteManager(new EfFavoriteDal());
            _carService = new CarManager(new EfCarDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCar();
            
        }

        private FavoriteManager _favoriteService;
        private CarManager _carService;

        private void ListCar()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Property.ToList();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                string Marka = dgwProduct.CurrentRow.Cells["Marka"].Value.ToString();
                string Model = dgwProduct.CurrentRow.Cells["Model"].Value.ToString();
                string Fiyat = dgwProduct.CurrentRow.Cells["Fiyat"].Value.ToString();
                string Renk = dgwProduct.CurrentRow.Cells["Renk"].Value.ToString();
                string KM = dgwProduct.CurrentRow.Cells["KM"].Value.ToString();
                string Yil = dgwProduct.CurrentRow.Cells["Yil"].Value.ToString();

                lblBrandText.Text = Marka;
                lblModelText.Text = Model;
                lblUnitPriceText.Text = Fiyat;
                lblColorText.Text = Renk;
                lblYearText.Text = Yil;
                lblKMText.Text = KM;
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
            if (dgwProduct.CurrentRow != null)
            {
                int selectedKartId = Convert.ToInt32(dgwProduct.CurrentRow.Cells["Id"].Value);
                string secilenMarka = dgwProduct.CurrentRow.Cells["Marka"].Value.ToString();
                string secilenModel = dgwProduct.CurrentRow.Cells["Model"].Value.ToString();

                RentalScreen screen = new RentalScreen
                {
                    CarId = selectedKartId,  // Seçili aracın Id'sini gönderin
                    Brand = secilenMarka,
                    Model = secilenModel,

                    Source = SourceForm.Form1 // Geçiş yapılan formu belirtin
                };

                screen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir araç seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                Console.ReadLine();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.ShowDialog();
        }

        //CarManager CarManager = new CarManager();

        private void btnAddFavorites_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Favorilerime eklendi.");
        }
    }
}


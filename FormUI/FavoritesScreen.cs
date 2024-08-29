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
    public partial class FavoritesScreen : Form
    {
        public FavoritesScreen()
        {
            InitializeComponent();
            //_carService = (CarManager)InstanceFactory.GetInstance<ICarService>();
            _favoriteService = new FavoriteManager(new EfFavoriteDal());
            
        }

        private FavoriteManager _favoriteService;

        private void FavoritesScreen_Load(object sender, EventArgs e)
        {
            ListFavorites();
        }

        private void ListFavorites() 
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var list = context.Favorite.ToList();
                dgwMyFavorites.DataSource = list;
            }
        }

        //private void LoadCars()
        //{
        //    dgwMyFavorites.DataSource = .GetAll();
        //}


        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgwMyFavorites.CurrentRow != null)
            {
                string Marka = dgwMyFavorites.CurrentRow.Cells["Marka"].Value.ToString();
                string Model= dgwMyFavorites.CurrentRow.Cells["Model"].Value.ToString();
                string Fiyat = dgwMyFavorites.CurrentRow.Cells["Fiyat"].Value.ToString();
                string Renk = dgwMyFavorites.CurrentRow.Cells["Renk"].Value.ToString();
                string Yil = dgwMyFavorites.CurrentRow.Cells["Yil"].Value.ToString();
                string KM = dgwMyFavorites.CurrentRow.Cells["KM"].Value.ToString();  //veri tabanında ekli değil

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

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (dgwMyFavorites.CurrentRow != null)
            {
                int secilenKartId = Convert.ToInt32(dgwMyFavorites.CurrentRow.Cells["PropertyId"].Value);
                string secilenMarka = dgwMyFavorites.CurrentRow.Cells["Marka"].Value.ToString();
                string secilenModel = dgwMyFavorites.CurrentRow.Cells["Model"].Value.ToString();

                RentalScreen screen = new RentalScreen
                {
                    CarId = secilenKartId,  // Seçili aracın Id'sini gönderin
                    Brand = secilenMarka,
                    Model = secilenModel,

                    Source = SourceForm.FavoritesScreen // Geçiş yapılan formu belirtin
                };

                screen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir araç seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwMyFavorites.CurrentRow != null)
            {
                try
                {
                    _favoriteService.Delete(new Favorite
                    {
                        Id = Convert.ToInt32(dgwMyFavorites.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün silindi!");
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            LoadProducts();

            
        }

        private void LoadProducts()
        {
            dgwMyFavorites.DataSource = _favoriteService.GetAll();
        }
    }
}

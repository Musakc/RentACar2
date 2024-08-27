using DataAccess.Concrete.EntityFramework;
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
        }

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

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgwMyFavorites.CurrentRow != null)
            {
                string Marka = dgwMyFavorites.CurrentRow.Cells["Marka"].Value.ToString();
                string Model= dgwMyFavorites.CurrentRow.Cells["Model"].Value.ToString();
                string Fiyat = dgwMyFavorites.CurrentRow.Cells["Fiyat"].Value.ToString();
                //string carColor = dgwMyFavorites.CurrentRow.Cells["CarColor"].Value.ToString();
                //string carFuel = dgwMyFavorites.CurrentRow.Cells["CarFuel"].Value.ToString();
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

        private void btnRent_Click(object sender, EventArgs e)
        {
            RentalScreen screen = new RentalScreen();
            screen.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class MainWindow : Form
    {
        private BindingSource shopsBindingSource = new BindingSource();
        static List<Product> products1 = new List<Product>()
        {
            new Product() {Id = 1, Name = "Apple"},
            new Product() {Id = 2, Name = "Tomato"},
            new Product() {Id = 3, Name = "Juice"}
        };

        static List<Product> products2 = new List<Product>()
        {
            new Product() {Id = 4, Name = "Potato"},
            new Product() {Id = 5, Name = "Orange"},
            new Product() {Id = 6, Name = "Meat"}
        };

        List<Shop> shops = new List<Shop>()
        {
            new Shop()
            {
                Id = 1,
                Name="Diksi",
                Products = products1,
            },
            new Shop()
            {
                Id = 2,
                Name="Paterka",
                Products= products2,
            }
        };

        private void addShop_btn_Click(object sender, EventArgs e)
        {
            if (shops == null)
            {
                shops = new List<Shop>();
                ShopsListBox.DataSource = shops;
            }

            Shop newShop = new Shop() { Id = shops.Count()+1, Name = nameShopTextBox.Text, Products = new List<Product>() };
            shops.Add(newShop);

            shopsBindingSource.ResetBindings(false);
        }

        public MainWindow()
        {
            InitializeComponent();
            ShopsListBox.DataSource = shopsBindingSource;

            shopsBindingSource.DataSource = shops;

            ShopsListBox.DisplayMember = "Name";
            ShopsListBox.ValueMember = "Id";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var shop = shops.Where(x => x.Id == ((Shop)ShopsListBox.SelectedItem).Id).FirstOrDefault();
            if (shop != null)
            {
                ProductsListBox.DataSource = shop.Products;
                ProductsListBox.DisplayMember = "Name";
                ProductsListBox.ValueMember = "Id";
            }

        }

        private void addItemToShop_Click(object sender, EventArgs e)
        {
            var shop = shops.Where(x => x.Id == ((Shop)ShopsListBox.SelectedItem).Id).FirstOrDefault();
            if (shop != null)
            {
                shop.Products.Add(new Product() { Id = shop.Products.Count() + 1, Name = ItemName.Text });
            }
            RefreshProductsListBox(shop);
        }
        private void RefreshProductsListBox(Shop shop)
        {
            ProductsListBox.DataSource = null;
            ProductsListBox.DataSource = shop.Products;
            ProductsListBox.DisplayMember = "Name";
            ProductsListBox.ValueMember = "Id";
        }

    }

    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

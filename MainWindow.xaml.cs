using System.Collections.Generic;
using System.Windows;

namespace WpfAppLists
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var products = new List<UserControl1.Product>
            {
                new UserControl1.Product
                {
                    Name = "Ноутбук",
                    Description = "Высокопроизводительный ноутбук для работы и игр",
                    Manufacturer = "Dell",
                    Price = 85000,
                    Stock = 5,
                    ImagePath = "Images/laptop.png"
                },
                new UserControl1.Product
                {
                    Name = "Смартфон",
                    Description = "Смартфон с отличной камерой и большим экраном",
                    Manufacturer = "Samsung",
                    Price = 55000,
                    Stock = 8,
                    ImagePath = "Images/phone.png"
                },
                new UserControl1.Product
                {
                    Name = "Наушники",
                    Description = "Беспроводные наушники с шумоподавлением",
                    Manufacturer = "Sony",
                    Price = 12000,
                    Stock = 15,
                    ImagePath = "Images/headphones.png"
                }
            };

            ProductList.ItemsSource = products;
        }
    }
}
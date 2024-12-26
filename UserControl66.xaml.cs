using System.Windows.Controls;

namespace WpfAppLists
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public class Product
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Manufacturer { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
            public string ImagePath { get; set; }
        }
    }
}
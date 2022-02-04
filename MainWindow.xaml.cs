using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14_Template
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                ProductName = "Ноутбук MSI GF65 10UE-064XRU",
                ProductPrice=97000,
                ProductСategory=ProductCategoryes.Бытовая_техника, //из перечисления enum
                ImagePath= "Data/10483315204.jpg"

            });
            products.Add(new Product()
            {
                ProductName = "Ноутбук ASUS TUF Dash F15 FX516",
                ProductPrice = 91999,
                ProductСategory = ProductCategoryes.Бытовая_техника,
                ImagePath = "Data/asus-tuf-dash-f15.jpg"

            });
            products.Add(new Product()
            {
                ProductName = "Бельгийский темный шоколад 2,5 кг.",
                ProductPrice = 2500,
                ProductСategory = ProductCategoryes.Еда,
                ImagePath = "Data/Callebaut-milk-block-POST.jpg"

            });
            lstbox.ItemsSource = products; //присваиваем список с задачами св-ву ItemSorse listboxa
        }
    }
}

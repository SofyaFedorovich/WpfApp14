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
using System.Collections.ObjectModel;

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

            public ObservableCollection<Product> products;

            public MainWindow()
            {
                InitializeComponent();
                products = new ObservableCollection<Product>
                {
                    new Product { NameProduct = "Авокадо", PriceProduct = 100, ImageProduct = @"Data\Avocado.jpg", CategoryProduct = Categories.Food },
                    new Product { NameProduct = "Редис", PriceProduct = 80, ImageProduct = @"Data\Radish.jpg", CategoryProduct = Categories.Food },
                    new Product { NameProduct = "Мультиварка", PriceProduct = 9000, ImageProduct = @"Data\Multicooker.jpg", CategoryProduct = Categories.Appliances },
                    new Product { NameProduct = "Тостер", PriceProduct = 2600, ImageProduct = @"Data\Toaster.jpg", CategoryProduct = Categories.Appliances }
                };

                listBox.ItemsSource = products;
            }
        
    }
}

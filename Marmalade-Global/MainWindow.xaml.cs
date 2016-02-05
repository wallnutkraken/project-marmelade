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

namespace Marmalade_Global
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Ingredient one = new Ingredient("TypeOne", 50.5, 12.2);
            Ingredient Two = new Ingredient("TypeTwo", 60.7, 15.3);

            Product ProductOne = new Product(1, "ProductTypeOne", "VarietyOne", 3, "Jar", 45, 23, one,Two);
            string test = ProductOne.ToString();

            Console.WriteLine();
        }
    }
}

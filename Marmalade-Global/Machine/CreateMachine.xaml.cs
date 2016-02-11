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
using System.Windows.Shapes;

namespace Marmalade_Global.Machine
{
    /// <summary>
    /// Interaction logic for CreateMachine.xaml
    /// </summary>
    public partial class CreateMachine : Window
    {
        public CreateMachine()
        {
            InitializeComponent();
            typeComboBox.ItemsSource = UtilityController.EnumToList<MachineType>();
            typeComboBox.SelectedIndex = 0;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            bool result = MachineController.AddMachine((MachineType)typeComboBox.SelectedItem, location.Text);
            if (result == true)
            {
                MessageBox.Show("Machine successfully added!", "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Machine could not be created.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void location_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= location_GotFocus;
        }
    }
}

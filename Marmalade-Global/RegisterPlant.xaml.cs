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

namespace Marmalade_Global
{
    /// <summary>
    /// Interaction logic for RegisterPlant.xaml
    /// </summary>
    public partial class RegisterPlant : Window
    {
        public RegisterPlant()
        {
            InitializeComponent();
        }

        private void btnRegisterPlant_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";
            if(string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorMessage = errorMessage + "Name field is empty!\n";
            }
            if(string.IsNullOrWhiteSpace(textBoxType.Text))
            {
                errorMessage = errorMessage + "Type field is empty!\n";
            }
            if (string.IsNullOrWhiteSpace(textBoxLifetime.Text))
            {
                errorMessage = errorMessage + "Lifetime field is empty!\n";
            }
            if (string.IsNullOrWhiteSpace(textBoxLifetime.Text))
            {
                errorMessage = errorMessage + "Lifetime field is empty!\n";
            }
            int intResult;
            if(!int.TryParse(textBoxLifetime.Text, out intResult) && !string.IsNullOrWhiteSpace(textBoxLifetime.Text))
            {
                errorMessage = errorMessage + "Lifetime should be a number!\n";
            }
            if (string.IsNullOrWhiteSpace(textBoxProcValue.Text))
            {
                errorMessage = errorMessage + "Procurement field is empty!\n";
            }
            double doubleResult;
            if (!double.TryParse(textBoxProcValue.Text, out doubleResult) && !string.IsNullOrWhiteSpace(textBoxProcValue.Text))
            {
                errorMessage = errorMessage + "Procurement should be a number!\n";
            }
            if (string.IsNullOrWhiteSpace(textBoxScrapValue.Text))
            {
                errorMessage = errorMessage + "Scrap value field is empty!\n";
            }
            if (!double.TryParse(textBoxScrapValue.Text, out doubleResult) && !string.IsNullOrWhiteSpace(textBoxScrapValue.Text))
            {
                errorMessage = errorMessage + "Scrap value should be a number!\n";
            }

            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                // no errors
            }
            
        }
    }
}

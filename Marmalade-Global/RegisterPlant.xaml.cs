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
            double resultLifetime;
            double resultProcValue;
            double resultScrapValue;
            double resultYearsUsed;
            if (!double.TryParse(textBoxLifetime.Text, out resultLifetime) && !string.IsNullOrWhiteSpace(textBoxLifetime.Text))
            {
                errorMessage = errorMessage + "Lifetime should be a number!\n";
            }
            if (string.IsNullOrWhiteSpace(textBoxProcValue.Text))
            {
                errorMessage = errorMessage + "Procurement field is empty!\n";
            }
            if (!double.TryParse(textBoxProcValue.Text, out resultProcValue) && !string.IsNullOrWhiteSpace(textBoxProcValue.Text))
            {
                errorMessage = errorMessage + "Procurement should be a number!\n";
            }
            if (string.IsNullOrWhiteSpace(textBoxScrapValue.Text))
            {
                errorMessage = errorMessage + "Scrap value field is empty!\n";
            }
            if (!double.TryParse(textBoxScrapValue.Text, out resultScrapValue) && !string.IsNullOrWhiteSpace(textBoxScrapValue.Text))
            {
                errorMessage = errorMessage + "Scrap value should be a number!\n";
            }
            if (string.IsNullOrWhiteSpace(textBoxYearsUsed.Text))
            {
                errorMessage = errorMessage + "Years used field is empty!\n";
            }
            if (!double.TryParse(textBoxYearsUsed.Text, out resultYearsUsed) && !string.IsNullOrWhiteSpace(textBoxYearsUsed.Text))
            {
                errorMessage = errorMessage + "Years used should be a number!\n";
            }

            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                // registering plant
                PlantController.RegisterPlant(textBoxName.Text, textBoxType.Text, resultLifetime, resultProcValue, resultScrapValue, resultYearsUsed);
            }
            
        }
    }
}

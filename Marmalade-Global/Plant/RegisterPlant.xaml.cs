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
            List<string> inputError = new List<string>();
            if(string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                inputError.Add("Name field is empty!\n");
            }
            if(string.IsNullOrWhiteSpace(textBoxType.Text))
            {
                inputError.Add("Type field is empty!\n");
            }
            if (string.IsNullOrWhiteSpace(textBoxLifetime.Text))
            {
                inputError.Add("Lifetime field is empty!\n");
            }
            double resultLifetime;
            double resultProcValue;
            double resultScrapValue;
            double resultYearsUsed;
            if (!double.TryParse(textBoxLifetime.Text, out resultLifetime) && !string.IsNullOrWhiteSpace(textBoxLifetime.Text))
            {
                inputError.Add("Lifetime should be a number!\n");
            }
            if (string.IsNullOrWhiteSpace(textBoxProcValue.Text))
            {
                inputError.Add("Procurement field is empty!\n");
            }
            if (!double.TryParse(textBoxProcValue.Text, out resultProcValue) && !string.IsNullOrWhiteSpace(textBoxProcValue.Text))
            {
                inputError.Add("Procurement should be a number!\n");
            }
            if (string.IsNullOrWhiteSpace(textBoxScrapValue.Text))
            {
                inputError.Add("Scrap value field is empty!\n");
            }
            if (!double.TryParse(textBoxScrapValue.Text, out resultScrapValue) && !string.IsNullOrWhiteSpace(textBoxScrapValue.Text))
            {
                inputError.Add("Scrap value should be a number!\n");
            }
            if (string.IsNullOrWhiteSpace(textBoxYearsUsed.Text))
            {
                inputError.Add("Years used field is empty!\n");
            }
            if (!double.TryParse(textBoxYearsUsed.Text, out resultYearsUsed) && !string.IsNullOrWhiteSpace(textBoxYearsUsed.Text))
            {
                inputError.Add("Years used should be a number!\n");
            }

            if (inputError.Count > 0)
            {
                string errorMessage = "";
                for (int i = 0; i < inputError.Count; i++)
                {
                    errorMessage = errorMessage + inputError[i];
                }
                MessageBox.Show(errorMessage);
            }
            else
            {
                // registering plant
                PlantController.RegisterPlant(textBoxName.Text, textBoxType.Text, resultLifetime, resultProcValue, resultScrapValue, resultYearsUsed);
                MessageBox.Show("REG SUCCESS!");
            }
            
        }
    }
}

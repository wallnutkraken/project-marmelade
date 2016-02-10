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
    /// Interaction logic for CreateEmployee.xaml
    /// </summary>
    public partial class CreateEmployee : Window
    {
        public CreateEmployee()
        {

            InitializeComponent();

            // set comobox.ItemsSource = IEnumerable for each combobox
            InitializeComboboxes();

        }

        List<T> EnumToListForCombobox<T>()
        {
            List<T> allEnums = Enum.GetValues(typeof(T)).Cast<T>().ToList();
            return allEnums;
        }
        /// <summary>
        /// Calls ViewController for getting domain enums into ienumerables ???? SD / layers 
        /// </summary>
        private void InitializeComboboxes()
        {
            shift_cbx.ItemsSource = EnumToListForCombobox<EmployeeStatuses.Shift>();
            maritalStatus_cbx.ItemsSource = EnumToListForCombobox<EmployeeStatuses.MaritalStatus>();
            department_cbx.ItemsSource = EnumToListForCombobox<EmployeeStatuses.Department>();
        }

        #region GotFocus Methods
        private void name_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= name_tbx_GotFocus;
        }

        private void address_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= address_tbx_GotFocus;
        }
        private void hourlyWage_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= hourlyWage_tbx_GotFocus;
        }
        private void phoneNr_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= phoneNr_tbx_GotFocus;
        }
        private void legalId_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= legalId_tbx_GotFocus;
        }

        #endregion

        private void button_Click(object sender, RoutedEventArgs e)
        {

            ConfirmInput();



        }

        /// <summary>
        /// Checks whether the input typed into the window is of the correct type.
        /// Returns true if no errors were found
        /// </summary>
        private bool ConfirmInput()
        {

            bool confirmed = false;
            //Collection all errors, so they can be displayed properly.
            List<string> errors = new List<string>();

            //Clear label in case of previous errors
            error_lbl.Content = "";

            double tryParse = 0; //tryParse return value

            //Add all textboxes in the window to a List<>
            List<TextBox> txtBxs = new List<TextBox>();

            foreach (UIElement ui in MainGrid.Children)
            {
                if (ui.GetType() == typeof(TextBox))
                {
                    txtBxs.Add((TextBox)ui);
                }
            }

            //Check if name is a string
            if (txtBxs[0].Name == "name_tbx")
            {

                tryParse = 0;
                double.TryParse(txtBxs[0].Text, out tryParse);
                if (tryParse != 0)
                {
                    errors.Add("Name cannot be a number");
                }
            }
            else
            {
                MessageBox.Show("name_tbx was changed or moved - CreateEmployee.xaml.cs ~ line 109");
            }

            if (txtBxs[1].Name == "address_tbx")
            {
                //Check if address is a string
                tryParse = 0;
                double.TryParse(txtBxs[1].Text, out tryParse);
                if (tryParse != 0)
                {
                    errors.Add("Address cannot be a number");
                }
            }
            else
            {
                MessageBox.Show("address_tbx was changed or moved - CreateEmployee.xaml.cs ~ line 125");
            }

            if (txtBxs[2].Name == "phoneNr_tbx")
            {
                txtBxs[2].Text = txtBxs[2].Text.Trim();
                if (txtBxs[2].Text.Length == 11)
                {
                    //Check if phonenumber starts with +45 and 8 digits follow.
                    if (txtBxs[2].Text[0] != '+' && txtBxs[2].Text[1] != '4' && txtBxs[2].Text[2] != '5')
                    {
                        errors.Add("Phone Number is not danish");
                    }

                    string number = "";
                    for (int i = 3; i < txtBxs[2].Text.Length; i++)
                    {
                        number += txtBxs[2].Text[i];
                    }

                    double.TryParse(number, out tryParse);

                    if (tryParse == 0)
                    {
                        errors.Add("Phone Number has to be a number");
                    }
                }
                else if (txtBxs[2].Text.Length != 11)
                {
                    errors.Add("Phone Number is not valid, remember +45");
                }
            }

            else
            {
                MessageBox.Show("phoneNr_tbx was changed or moved - CreateEmployee.xaml.cs ~ line 138");
            }

            //Check if wage is double
            if (txtBxs[3].Name == "hourlyWage_tbx")
            {
                double.TryParse(txtBxs[3].Text, out tryParse);
                if (tryParse == 0)
                {
                    errors.Add("Wage has to be a number");
                }
            }
            else
            {
                MessageBox.Show("hourlyWage_tbx was changed or moved - CreateEmployee.xaml.cs ~ line 170");
            }

            //Check if CPR starts with 6 possible digits and 4 digits follow. 
            if (txtBxs[4].Name == "legalId_tbx")
            {
                bool number = false;
            

                string dd = "";
                string mm = "";
                string yy = "";
                int date = 0;
                int month = 0;
                int year = 0;

                int outInt = 0;

                if (txtBxs[4].Text.Length == 10)
                {
                    dd = txtBxs[4].Text[0].ToString() + txtBxs[4].Text[1].ToString();
                    mm = txtBxs[4].Text[2].ToString() + txtBxs[4].Text[3].ToString();
                    yy = txtBxs[4].Text[4].ToString() + txtBxs[4].Text[5].ToString();

                    int.TryParse(dd, out outInt);
                    if (outInt != 0)
                    {
                        date = outInt;
                    }
                    else
                    {
                        number = false;
                    }

                    int.TryParse(mm, out outInt);
                    if (outInt != 0)
                    {
                        month = outInt;
                    }
                    else
                    {
                        number = false;
                    }

                    int.TryParse(yy, out outInt);
                    if (outInt != 0)
                    {
                        year = outInt;
                    } else
                    {
                        number = false;
                    }

                }

                double.TryParse(txtBxs[4].Text, out tryParse);

                if (tryParse != 0)
                {

                    if (date > 31 || date < 0)
                    {
                        errors.Add("Date doesn't exsist");
                    }

                    if (month > 12 || month < 0)
                    {
                        errors.Add("Month doesn't exist");
                    }

                    if (year > 16 || year < 0)
                    {
                        errors.Add("Year is not possible");
                    }
                }
                else if (txtBxs[4].Text.Length != 10)
                {
                    errors.Add("CPR has to be 10 digits long");
                }
                else if (tryParse == 0 || !number)
                {
                    errors.Add("CPR has to be a number");
                }

            }

            else
            {
                MessageBox.Show("legalId_tbx was changed or moved - CreateEmployee.xaml.cs ~ line 183");
            }
            MessageBox.Show(errors.Count + " errors were found");
            for (int i = 0; i < errors.Count; i++)
            {
                if (i == 0)
                {
                    error_lbl.Content = errors[i];
                }
                else
                {
                    error_lbl.Content += "\n" + errors[i];
                }
            }

            if(errors.Count == 0)
            {
                confirmed = true;
            }

            return confirmed;
        }

        private void createEmployee_btn_Click(object sender, RoutedEventArgs e)
        {
            if (ConfirmInput()) { 
            string name = name_tbx.Text;
            string phoneNo = phoneNr_tbx.Text;
            string address = address_tbx.Text;
            double hourlyWage = Convert.ToDouble(hourlyWage_tbx.Text);
            string personalID = legalId_tbx.Text;
            EmployeeStatuses.Department department = (EmployeeStatuses.Department)Enum.Parse(typeof(EmployeeStatuses.Department), department_cbx.Text);

            EmployeeStatuses.MaritalStatus marital = (EmployeeStatuses.MaritalStatus)Enum.Parse(typeof(EmployeeStatuses.MaritalStatus), maritalStatus_cbx.Text);


            if (!shift_cbx.Text.Equals(""))
            {
                EmployeeStatuses.Shift shift = (EmployeeStatuses.Shift)Enum.Parse(typeof(EmployeeStatuses.Shift), shift_cbx.Text);
                EmployeeController.CreateEmployee(name,
                                phoneNo,
                                address,
                                hourlyWage,
                                personalID,
                                shift,
                                department,
                                marital);
            }
            else
            {
                EmployeeController.CreateEmployee(name,
                                phoneNo,
                                address,
                                hourlyWage,
                                personalID,
                                department,
                                marital);
            }


        }
        }
    }
}

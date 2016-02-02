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
            shift_cbx.ItemsSource = EnumToListForCombobox<EmployeeEnums.Shift>();
            maritalStatus_cbx.ItemsSource = EnumToListForCombobox<EmployeeEnums.MaritalStatus>();
            department_cbx.ItemsSource = EnumToListForCombobox<EmployeeEnums.Department>();
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

        private void createEmployee_btn_Click(object sender, RoutedEventArgs e)
        {
            string name = name_tbx.Text;
            string phoneNo = phoneNr_tbx.Text;
            string address = address_tbx.Text;
            double hourlyWage = Convert.ToDouble(hourlyWage_tbx.Text);
            string personalID = legalId_tbx.Text;
            EmployeeEnums.Department department = (EmployeeEnums.Department)Enum.Parse(typeof(EmployeeEnums.Department), department_cbx.Text);

            EmployeeEnums.MaritalStatus marital = (EmployeeEnums.MaritalStatus)Enum.Parse(typeof(EmployeeEnums.MaritalStatus), maritalStatus_cbx.Text);


            if (!shift_cbx.Text.Equals(""))
            {
                EmployeeEnums.Shift shift = (EmployeeEnums.Shift)Enum.Parse(typeof(EmployeeEnums.Shift), shift_cbx.Text);
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

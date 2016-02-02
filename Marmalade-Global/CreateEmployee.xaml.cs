﻿using System;
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
            //InitializeComboboxes();
            
            // ****
            //comboBox.ItemsSource = test();

        }

        enum MyEnum
        {
            hello,
            bye
        }

        List<MyEnum> test()
        {
            List<MyEnum> allEnums = Enum.GetValues(typeof(MyEnum)).Cast<MyEnum>().ToList();
            return allEnums;
        }
        /// <summary>
        /// Calls ViewController for getting domain enums into ienumerables ???? SD / layers 
        /// </summary>
        private void InitializeComboboxes()
        {
            throw new NotImplementedException();
        }

        // textBox_GotFocus events => sets tetbox content to empty on the first click

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

    }
}
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

            comboBox.ItemsSource = test();
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



    }
}

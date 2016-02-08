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
    /// Interaction logic for EmployeeSchedule.xaml
    /// </summary>
    public partial class EmployeeSchedule : Window
    {
        public EmployeeSchedule()
        {
            InitializeComponent();

            DateTime now = new DateTime(2016, 02, 02, 8, 0, 0);

            for (int i = 0; i < 28; i++)
            {
                DateTime currentTime = now.AddMinutes(15 * i);
                ScheduleEntry entry = new ScheduleEntry();
                entry.time.Content = currentTime.ToShortTimeString();
                entry.description.Content = "Hello you little fuck!";

                stack.Children.Add(entry);
            }
        }


    }
}

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
        int[] Days = { 1, 2, 3, 4, 5 };
        List<ProductionTask> tasks;
        public EmployeeSchedule()
        {
            InitializeComponent();
            daySelect.ItemsSource = Days;
            daySelect.SelectedIndex = 0;

            tasks = /* Some controller method to give this thing tasks */ null;
        }
        
        /// <summary>
        /// Updates the window with selected day of the week
        /// </summary>
        private void Update()
        {
            DateTime currentTime = DateTime.UtcNow;
            /* Beginning of the day */
            DateTime now = new DateTime(currentTime.Year, currentTime.Month, (int)daySelect.SelectedItem, 8, 0, 0);
            /* Not sure how to actually initialize the DateTime here, so these constructor arguments probably don't */
            /* make a whole lot of sense. */
            if (tasks != null)
            {
                foreach(ProductionTask task in tasks)
                {
                    /* Deal with every task passed onto the current window */
                    ScheduleEntry entry = new ScheduleEntry();
                    entry.SetEntry(now, task.Duration, $"Work on {task.MachineTypeRequired.ToString()}");
                    stack.Children.Add(entry);
                    now = entry.EndingTime();
                }
            }
            
        }

        private void daySelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }
    }
}

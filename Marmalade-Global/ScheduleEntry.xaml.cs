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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Marmalade_Global
{
    /// <summary>
    /// Interaction logic for ScheduleEntry.xaml
    /// </summary>
    public partial class ScheduleEntry : UserControl
    {
        public TimeSpan Duration { get; set; }
        private DateTime previousEnd;
        public ScheduleEntry()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets up the entry for the schedule
        /// </summary>
        /// <param name="previousTaskEnd">The time where the task before this ended</param>
        /// <param name="duration"></param>
        /// <param name="taskDescription"></param>
        public void SetEntry(DateTime previousTaskEnd, TimeSpan duration, string taskDescription)
        {
            previousEnd = previousTaskEnd;
            Duration = duration;
            description.Content = taskDescription;
            time.Content = previousTaskEnd.ToShortTimeString();
        }

        /// <summary>
        /// Calculates the time this task should end in
        /// </summary>
        /// <returns>DateTime of the ending</returns>
        public DateTime EndingTime()
        {
            return previousEnd.Add(Duration);
        }
    }
}

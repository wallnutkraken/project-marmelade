using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    /// Interaction logic for CreateSchedule.xaml
    /// </summary>
    public partial class CreateSchedule : Window
    {
        Scheduler scheduler = new Scheduler();
        public CreateSchedule()
        {
            InitializeComponent();

        }

        private void createSchedule_btn_Click(object sender, RoutedEventArgs e)
        {
            int weekNumber = 1;

            scheduler.fillLists();

            scheduler.CreateScheduleForAllMachines(weekNumber);
        }
    }
}

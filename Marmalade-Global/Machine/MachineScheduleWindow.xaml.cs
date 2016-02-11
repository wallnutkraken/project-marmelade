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

namespace Marmalade_Global.Machine
{
    /// <summary>
    /// Interaction logic for MachineScheduleWindow.xaml
    /// </summary>
    public partial class MachineScheduleWindow : Window
    {
        public MachineScheduleWindow()
        {
            InitializeComponent();
            FillCombobox();
        }

        private void daySelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateByWeek();
        }

        void FillCombobox()
        {
            List<int> weekNumbers = new List<int>();

            for (int i = 1; i < 53; i++)
            {
                weekNumbers.Add(i);
            }

            selectedWeek_cbx.ItemsSource = weekNumbers;

            selectedMachine_cbx_.ItemsSource = Scheduler.allMachines;

        }

        private void UpdateByWeek()
        {
            int selectedWeek =  (int)selectedWeek_cbx.SelectedItem;



        }

        private void UpdateByMachine()
        {

        }
        private void selectedMachine_cbx__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateByMachine();
        }
    }
}

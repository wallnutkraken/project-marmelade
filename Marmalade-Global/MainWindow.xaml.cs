﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            testmethod();


        }
        void testmethod()
        {
            CreateEmployee newWindow = new CreateEmployee();
            newWindow.Show();

            CreateSchedule newWindow1 = new CreateSchedule();
            newWindow1.Show();

            Marmalade_Global.Machine.CreateMachine machineWindow = new Machine.CreateMachine();
            machineWindow.Show();
            PlantWindow plantWindow = new PlantWindow();
            plantWindow.Show();
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown(0);
        }
    }
}

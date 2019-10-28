﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VendingMachine.ViewModel
{
    class MainWindowViewModel
    {
        MainWindow window;
        public MainWindowViewModel()
        {
            window = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            window.Machine.Children.Add(new View.MachineView());
            window.User.Children.Add(new View.UserView());
        } 
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VendingMachine.ViewModel;

namespace VendingMachine.Model
{
    class PanelModel : INotifyPropertyChanged
    {
        private int count;
        private int price;
        private string name;

        public DelegateCommand Command { get; set; }

        public int Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged(nameof(Count));
            }
        }

        public int Price
        {
            get => price;
            set
            {
                price = value;
                OnPropertyChanged(nameof(Price));
            }
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public PanelModel()
        {
            Command = new DelegateCommand(o => { Method(); });
        }

        public void Method()
        {
            var mainWindow = MainWindowViewModel.GetMainWindowSingleton();
            if (Count > 0 && mainWindow.InputSumma-Price >= 0)
            {
                Count--;
                mainWindow.InputSumma -= Price;
                MessageBox.Show("Операция выполнена успешно!");
            }
            else MessageBox.Show("Ошибка операции!");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

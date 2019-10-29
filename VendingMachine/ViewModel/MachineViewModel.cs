using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VendingMachine.Model;

namespace VendingMachine.ViewModel
{
    class MachineViewModel: DependencyObject, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private int inputsumma;
        public int InputSumma
        {
            get => inputsumma;
            set
            {
                inputsumma = value;
                OnPropertyChanged(nameof(InputSumma));
            }
        }
        public MachineViewModel()
        {
            
        }
    }
}

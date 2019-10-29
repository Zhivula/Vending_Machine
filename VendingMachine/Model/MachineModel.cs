using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VendingMachine.Model
{
    class MachineModel: INotifyPropertyChanged
    {
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
        public ObservableCollection<Wallet> Items { get; set; }
        public MachineModel()
        {
            var items = new UserModel();
            Items = items.Items;
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}

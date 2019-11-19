using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VendingMachine.ViewModel;

namespace VendingMachine.Model
{
    class UserWallet : INotifyPropertyChanged
    {
        private int count;
        private int facevalue;
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
        public int FaceValue
        {
            get => facevalue;
            set
            {
                facevalue = value;
                OnPropertyChanged(nameof(FaceValue));
            }
        }
        public string FaceValueName
        {
            get => FaceValue.ToString() + "р.";
        }
        public UserWallet()
        {
            Command = new DelegateCommand(o=> { Method(); });
        }
        public void Method()
        {
            var mainWindowViewModel = MainWindowViewModel.GetMainWindowSingleton();
            if (Count > 0)
            {
                Count--;
                mainWindowViewModel.InputSumma += FaceValue;
                MessageBox.Show("Операция выполнена успешно!");
            }
            else MessageBox.Show("Ошибка операции!");
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
             PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));
        }
    }
}

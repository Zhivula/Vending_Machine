using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Model;

namespace VendingMachine.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private static MainWindowViewModel mainWindowSingleton;

        private int inputSumma;

        public List<UserWallet> Items { get; set; }

        public List<PanelModel> Panels { get; set; }

        public DelegateCommand ReturnMoney { get; set; }

        public int InputSumma
        {
            get => inputSumma;
            set
            {
                inputSumma = value;
                OnPropertyChanged(nameof(InputSumma));
            }
        }

        public MainWindowViewModel()
        {
            Items = new List<UserWallet>
            {
                new UserWallet()
                {
                    Count = 20,
                    FaceValue = 1
                },
                new UserWallet()
                {
                    Count = 20,
                    FaceValue = 2
                },
                new UserWallet()
                {
                    Count = 20,
                    FaceValue = 5
                },
                new UserWallet()
                {
                    Count = 20,
                    FaceValue = 10
                }
            };
            Panels = new List<PanelModel>
            {
                new PanelModel
                {
                    Count = 10,
                    Name = "Чай",
                    Price = 1
                },
                new PanelModel
                {
                    Count = 20,
                    Name = "Кофе",
                    Price = 2
                },
                new PanelModel
                {
                    Count = 35,
                    Name = "Сок",
                    Price = 5
                },
                new PanelModel
                {
                    Count = 5,
                    Name = "Лимонад",
                    Price = 1
                }
            };
            ReturnMoney = new DelegateCommand(o=> { ReturnMoneyMethod(); });
        }

        /// <summary>
        /// Реализация паттерна Singeleton. 
        /// </summary>
        /// <returns></returns>
        public static MainWindowViewModel GetMainWindowSingleton()
        {
            if (mainWindowSingleton == null)
                mainWindowSingleton = new MainWindowViewModel();
            return mainWindowSingleton;
        }
        public void ReturnMoneyMethod()
        {
            var algorithm = new Algorithm();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

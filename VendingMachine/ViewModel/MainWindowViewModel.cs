using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.DataBase;
using VendingMachine.Model;

namespace VendingMachine.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private static MainWindowViewModel mainWindowSingleton;

        private MainWindowModel mainWindowModel;

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
            
            mainWindowModel = new MainWindowModel();
            Items = mainWindowModel.Items;
            Panels = mainWindowModel.Panels;
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
        /// <summary>
        /// Метод возвращения внесенной суммы на кошелек пользователя.
        /// </summary>
        public void ReturnMoneyMethod()
        {
            var algorithm = new Algorithm(Items.Select( x => x.FaceValue).ToArray(), InputSumma);

            int i = 0;
            foreach (var item in Items)
            {                
                item.Count += algorithm.result[i];
                i++;
            }
            InputSumma = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

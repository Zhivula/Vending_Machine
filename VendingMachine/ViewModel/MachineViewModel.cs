using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VendingMachine.ViewModel
{
    class MachineViewModel
    {
        public ObservableCollection<PanelViewModel> Panels { get; set; } = new ObservableCollection<PanelViewModel>();
        public MachineViewModel()
        {
            Panels.Add(new PanelViewModel
            {
                Name = "A",
                Price = 10,
                Count = 10,
                Command = new Model.DelegateCommand(o => { Clicked(); })
            });
            Panels.Add(new PanelViewModel
            {
                Name = "A",
                Price = 10,
                Count = 10,
                Command = new Model.DelegateCommand(o => { Clicked(); })
            });
                        Panels.Add(new PanelViewModel
            {
                Name = "A",
                Price = 10,
                Count = 10,
                Command = new Model.DelegateCommand(o => { Clicked(); })
            });
        }

        void Clicked()
        {
            MessageBox.Show("Кнопка нажата!");
        }
    }
}

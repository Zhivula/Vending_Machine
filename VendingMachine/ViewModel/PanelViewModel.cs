using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace VendingMachine.ViewModel
{
    class PanelViewModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public ICommand Command { get; set; }
    }
}

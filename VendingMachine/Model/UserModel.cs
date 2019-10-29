using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VendingMachine.Model;

namespace VendingMachine.Model
{
    class UserModel
    {
        public ObservableCollection<Wallet> Items { get; set; }
        public UserModel()
        {
            Items = new ObservableCollection<Wallet>
            {
                new Wallet {FaceValue=1, Count=10 },
                new Wallet {FaceValue=2, Count=30 },
                new Wallet {FaceValue=5, Count=20 },
                new Wallet {FaceValue=5, Count=20 },
            };

        }
    }
}

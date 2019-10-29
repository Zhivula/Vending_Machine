using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Model;

namespace VendingMachine.ViewModel
{
    class UserViewModel
    {
        public ObservableCollection<Wallet> Items { get; set; }
        public UserViewModel()
        {
            Items = new UserModel().Items;

        }
    }
}

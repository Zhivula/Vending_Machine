using System.Collections.Generic;
using System.Linq;
using VendingMachine.DataBase;

namespace VendingMachine.Model
{
    class MainWindowModel
    {
        public List<UserWallet> Items;

        public List<PanelModel> Panels;

        public MainWindowModel()
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
            Panels = new List<PanelModel>();

            using (var context = new MyDbContext())
            {
                 foreach (var item in context.Products)
                 {
                     Panels.Add(new PanelModel
                     {
                         Count = item.Count,
                         Price = item.Price,
                         Name = item.Name
                     });
                 }
                
            }
        }
    }
}
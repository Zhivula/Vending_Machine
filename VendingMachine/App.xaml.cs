using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VendingMachine.DataBase;
using VendingMachine.Model;

namespace VendingMachine
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            using (var context = new MyDbContext())
            {
                context.Products.Add(new Product
                {
                    Count = 10,
                    Name = "Чай",
                    Price = 1
                });
                context.Products.Add(new Product
                {
                    Count = 20,
                    Name = "Кофе",
                    Price = 2
                });
                context.Products.Add(new Product
                {
                    Count = 35,
                    Name = "Сок",
                    Price = 5
                });
                context.Products.Add(new Product
                {
                    Count = 5,
                    Name = "Лимонад",
                    Price = 1
                });
                context.SaveChanges();
            } //Занесение данные в базу данных
        }
    }
}

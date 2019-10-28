using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VendingMachine.View
{
    /// <summary>
    /// Логика взаимодействия для PanelView.xaml
    /// </summary>
    public partial class PanelView : UserControl
    {
        public PanelView()
        {
            InitializeComponent();
            DataContext = new ViewModel.PanelViewModel();
        }

        public int Price
        {
            get => (int)GetValue(PriceProperty);
            set => SetValue(PriceProperty, value);
        }

        public int Count
        {
            get => (int)GetValue(CountProperty);
            set => SetValue(CountProperty, value);
        }
        public string NameProduct
        {
            get => (string)GetValue(NameProductProperty);
            set => SetValue(NameProductProperty, value);
        }

        public ICommand ButtonCommand
        {
            get => (ICommand)GetValue(ButtonCommandProperty);
            set => SetValue(ButtonCommandProperty, value);
        }

        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(int), typeof(PanelView), new PropertyMetadata(0));

        public static readonly DependencyProperty CountProperty =
            DependencyProperty.Register("Count", typeof(int), typeof(PanelView), new PropertyMetadata(0));

        public static readonly DependencyProperty NameProductProperty =
            DependencyProperty.Register("NameProduct", typeof(string), typeof(PanelView), new PropertyMetadata("NameProduct"));

        public static readonly DependencyProperty ButtonCommandProperty =
            DependencyProperty.Register("ButtonCommand", typeof(ICommand), typeof(PanelView), new PropertyMetadata(null));
    }
}
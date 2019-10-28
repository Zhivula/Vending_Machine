using System.Windows.Controls;

namespace VendingMachine.View
{
    /// <summary>
    /// Логика взаимодействия для MachineView.xaml
    /// </summary>
    public partial class MachineView : UserControl
    {
        public MachineView()
        {
            InitializeComponent();
            DataContext = new ViewModel.MachineViewModel();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    class Wallet : INotifyPropertyChanged
    {
        private int count;
        private int facevalue;
        public DelegateCommand Command { get; set; }

        public int FaceValue
        {
            get { return facevalue; }
            set
            {
                facevalue = value;
                OnPropertyChanged(nameof(FaceValue));
            }
        }
        public string FaceValueName
        {
            get { return facevalue + "р."; }
        }
        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                OnPropertyChanged(nameof(Count));
            }
        }
        public Wallet()
        {
            Command = new DelegateCommand(o => { Method(); });
        }
        private void Method()
        {
            if (Count > 0)
            {
                Count--;
                var machine = new MachineModel() { InputSumma = FaceValue };
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

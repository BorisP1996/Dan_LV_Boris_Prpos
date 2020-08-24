using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zadatak_1.Model;

namespace Zadatak_1.ViewModel
{
    class MainWindowViewModel:ViewModelBase
    {
        MainWindow main;

        public MainWindowViewModel(MainWindow mainOpen)
        {
            main = mainOpen;
            Pizza = new Pizza();
        }

        private Pizza pizza;

        public Pizza Pizza
        {
            get { return pizza; }
            set { pizza = value;
                OnPropertyChanged("Pizza");
            }
        }


        private int totalPrice;

        public int TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private string labelMessage;

        public string LabelMessage
        {
            get { return labelMessage; }
            set { labelMessage = value;
                OnPropertyChanged("LabelMessage");
            }
        }


        private ICommand calculateAmount;
        public ICommand CalculateAmount
        {
            get
            {
                if (calculateAmount==null)
                {
                    calculateAmount = new RelayCommand(param => CalculateAmountExecute(), param => CanCalculateAmountExecute());
                }
                return calculateAmount;
            }
        }

        private bool CanCalculateAmountExecute()
        {
            return true;
        }

        private void CalculateAmountExecute()
        {
            Pizza newPiza = new Pizza();
            newPiza.SalamaB = Pizza.SalamaB;
            if (newPiza.SalamaB==true)
            {
                LabelMessage = newPiza.salama.ToString();
            }
        }
    }
}

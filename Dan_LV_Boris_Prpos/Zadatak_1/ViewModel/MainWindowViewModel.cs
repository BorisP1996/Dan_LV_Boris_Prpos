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
            int suma = 0;
            Pizza newPiza = new Pizza();
            newPiza.SalamaB = Pizza.SalamaB;
            newPiza.KulenB = Pizza.KulenB;
            newPiza.SunkaB = Pizza.SunkaB;
            newPiza.SirB = Pizza.SirB;
            newPiza.KecapB = Pizza.KecapB;
            newPiza.MajonezB = Pizza.MajonezB;
            newPiza.SusamB = Pizza.SusamB;
            newPiza.PaprikaB = Pizza.PaprikaB;
            newPiza.MaslineB = Pizza.MaslineB;
            newPiza.OriganoB = Pizza.OriganoB;

            newPiza.SmallP = Pizza.SmallP;
            newPiza.MediumP = Pizza.MediumP;
            newPiza.BigP = Pizza.BigP;

            if (newPiza.SalamaB==true)
            {
                suma += newPiza.salama;
            }
            if (newPiza.KulenB==true)
            {
                suma += newPiza.kulen;
            }
            if (newPiza.SunkaB==true)
            {
                suma += newPiza.sunka;
            }
            if (newPiza.SirB==true)
            {
                suma += newPiza.sir;
            }
            if (newPiza.KecapB==true)
            {
                suma += newPiza.kecap;
            }
            if (newPiza.MajonezB==true)
            {
                suma += newPiza.majonez;
            }
            if (newPiza.SusamB == true)
            {
                suma += newPiza.susam;
            }
            if (newPiza.PaprikaB == true)
            {
                suma += newPiza.paprika;
            }
            if (newPiza.MaslineB == true)
            {
                suma += newPiza.masline;
            }
            if (newPiza.OriganoB == true)
            {
                suma += newPiza.origano;
            }
            if (newPiza.SmallP==true)
            {
                suma += newPiza.smallPiza;
            }
            if (newPiza.MediumP == true)
            {
                suma += newPiza.mediumPiza;
            }
            if (newPiza.BigP == true)
            {
                suma += newPiza.biggPiza;
            }
            LabelMessage = "Total price: " + suma.ToString();
        }
    }
}

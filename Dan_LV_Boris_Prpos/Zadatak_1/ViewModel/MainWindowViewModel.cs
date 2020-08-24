using System;
using System.Windows;
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

        #region Properties
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
        #endregion

        //Command that will calculate price for every selected component=>also pay atention to what it does in code behind
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

        /// <summary>
        /// Only (and minimum) one pizza type can be selected
        /// </summary>
        /// <returns></returns>
        private bool CanCalculateAmountExecute()
        {
            try
            {
                if (Pizza.SmallP == true && Pizza.MediumP == true)
                {
                    return false;
                }
                if (Pizza.SmallP == true && Pizza.BigP == true)
                {
                    return false;
                }
                if (Pizza.MediumP == true && Pizza.BigP == true)
                {
                    return false;
                }
                if (Pizza.MediumP == false && Pizza.SmallP == false && Pizza.BigP == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        //if checkbox is chehcked=>add price to total sum and display it in label
        private void CalculateAmountExecute()
        {
            try
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

                if (newPiza.SalamaB == true)
                {
                    suma += newPiza.salama;
                }
                if (newPiza.KulenB == true)
                {
                    suma += newPiza.kulen;
                }
                if (newPiza.SunkaB == true)
                {
                    suma += newPiza.sunka;
                }
                if (newPiza.SirB == true)
                {
                    suma += newPiza.sir;
                }
                if (newPiza.KecapB == true)
                {
                    suma += newPiza.kecap;
                }
                if (newPiza.MajonezB == true)
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
                if (newPiza.SmallP == true)
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
                LabelMessage = "Ukupna cijena: " + suma.ToString() + " RSD";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Pay atention to what it does in code behind, also it clears label
        /// </summary>
        private ICommand order;
        public ICommand Order
        {
            get
            {
                if (order==null)
                {
                    order = new RelayCommand(param => OrderExecute(), param => CanOrderExecute());
                }
                return order;
            }
        }

        private void OrderExecute()
        {
            try
            {
                LabelMessage = "";               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanOrderExecute()
        {
            if (CanCalculateAmountExecute()==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

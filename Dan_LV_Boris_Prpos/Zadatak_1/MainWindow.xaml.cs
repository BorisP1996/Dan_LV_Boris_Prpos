﻿using System;
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
using Zadatak_1.ViewModel;

namespace Zadatak_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            chkSalama.IsEnabled = false;
            chkSir.IsEnabled = false;
            chkSusam.IsEnabled = false;
            chkMajonez.IsEnabled = false;
            chkMasline.IsEnabled = false;
            chkKecap.IsEnabled = false;
            chkKulen.IsEnabled = false;
            chkOrigano.IsEnabled = false;
            chkSunka.IsEnabled = false;
            chkPaprika.IsEnabled = false;

            chkSmall.IsEnabled = false;
            chkMedium.IsEnabled = false;
            chkBig.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //enable them 
            chkSalama.IsEnabled = true;
            chkSir.IsEnabled = true;
            chkSusam.IsEnabled = true;
            chkMajonez.IsEnabled = true;
            chkMasline.IsEnabled = true;
            chkKecap.IsEnabled = true;
            chkKulen.IsEnabled = true;
            chkOrigano.IsEnabled = true;
            chkSunka.IsEnabled = true;
            chkPaprika.IsEnabled = true;

            chkSmall.IsEnabled = true;
            chkMedium.IsEnabled = true;
            chkBig.IsEnabled = true;

            //uncheck all of them
            chkSalama.IsChecked = false;
            chkSir.IsChecked = false;
            chkSusam.IsChecked = false;
            chkMajonez.IsChecked = false;
            chkMasline.IsChecked = false;
            chkKecap.IsChecked = false;
            chkKulen.IsChecked = false;
            chkOrigano.IsChecked = false;
            chkSunka.IsChecked = false;
            chkPaprika.IsChecked = false;

            chkSmall.IsChecked = false;
            chkMedium.IsChecked = false;
            chkBig.IsChecked = false;

            MessageBox.Show("Pica je porucena!");
            Naruci.Command.Execute(Naruci.CommandParameter);
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //enable them 
            chkSalama.IsEnabled = true;
            chkSir.IsEnabled = true;
            chkSusam.IsEnabled = true;
            chkMajonez.IsEnabled = true;
            chkMasline.IsEnabled = true;
            chkKecap.IsEnabled = true;
            chkKulen.IsEnabled = true;
            chkOrigano.IsEnabled = true;
            chkSunka.IsEnabled = true;
            chkPaprika.IsEnabled = true;

            chkSmall.IsEnabled = true;
            chkMedium.IsEnabled = true;
            chkBig.IsEnabled = true;

            //uncheck all of them
            chkSalama.IsChecked = false;
            chkSir.IsChecked = false;
            chkSusam.IsChecked = false;
            chkMajonez.IsChecked = false;
            chkMasline.IsChecked = false;
            chkKecap.IsChecked = false;
            chkKulen.IsChecked = false;
            chkOrigano.IsChecked = false;
            chkSunka.IsChecked = false;
            chkPaprika.IsChecked = false;

            chkSmall.IsChecked = false;
            chkMedium.IsChecked = false;
            chkBig.IsChecked = false;

            Naruci.Command.Execute(Naruci.CommandParameter);
        }
    }
}

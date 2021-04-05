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

namespace Zamestnanec
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lf_Name(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                NameAlert.Visibility = Visibility.Visible;
            }
            else
            {
                NameAlert.Visibility = Visibility.Hidden;
            }
        }
        private void lf_Sur(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                SurenameAlert.Visibility = Visibility.Visible;
            }
            else
            {
                SurenameAlert.Visibility = Visibility.Hidden;
            }
        }
        private void lf_Dob(object sender, RoutedEventArgs e)
        {
            if ((sender as DatePicker).SelectedDate == null)
            {
                DobAlert.Visibility = Visibility.Visible;
            }
            else
            {
                DobAlert.Visibility = Visibility.Hidden;
            }
        }
        private void lf_Edu(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                EduAlert.Visibility = Visibility.Visible;
            }
            else
            {
                EduAlert.Visibility = Visibility.Hidden;
            }
        }
        private void lf_PracPos(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                PracPosAlert.Visibility = Visibility.Visible;
            }
            else
            {
                PracPosAlert.Visibility = Visibility.Hidden;
            }
        }
        private void lf_Mon(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                MonAlert.Visibility = Visibility.Visible;
            }
            else
            {
                try
                {
                    Convert.ToDouble((sender as TextBox).Text);
                    MonAlert.Visibility = Visibility.Hidden;
                }
                catch
                {
                    MonAlert.Visibility = Visibility.Visible;
                }
            }
        }
        private void But_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Zamestnanecc zam = new Zamestnanecc(NameTB.Text, SurTB.Text, Convert.ToDateTime(DobTB.Text), EduTB.Text, PracPosTB.Text, Convert.ToDouble(MoneyTB.Text));
                MessageBox.Show($@"Novy zamestnanec byl vytvoren:
          Jmeno: {zam.Name}
       Prijmeni: {zam.Surname}
 Datum Narozeni: {zam.Dob}
       Vzdelani: {zam.Edu}
Pracovni Pozice: {zam.PracPos}
 Hruby plat ($): {zam.Mon}");
            }
            catch
            {
                lf_Name(NameTB, e);
                lf_Sur(SurTB, e);
                lf_Dob(DobTB, e);
                lf_Edu(EduTB, e);
                lf_PracPos(PracPosTB, e);
                lf_Mon(MoneyTB, e);
                MessageBox.Show("Chyba");
            }
            
        }
    }
}

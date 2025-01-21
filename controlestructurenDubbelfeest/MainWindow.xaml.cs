using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

namespace controlestructurenDubbelfeest
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            bool inputUser = double.TryParse(aantalPersonenTextBox.Text, out double aantalPersonen);
            double dagen = 365;
            double totaalpercentage = 0;





            if (inputUser == false || aantalPersonen < 2)
            {

                MessageBox.Show("Geef een geheel getal in vanaf 2", "Error", MessageBoxButton.OK);

            }
            else if (inputUser == true)

            {
                for (int i = 1 ; i < aantalPersonen; i++)
                {
                    dagen -= i;
                    totaalpercentage = (1 - (dagen / 365)) * 100; 


                }

                resultTextBox.Text = $" Kans op gelijke verjaardag is {totaalpercentage} %";


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            aantalPersonenTextBox.Clear();
        }
    }
}

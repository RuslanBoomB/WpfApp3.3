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

namespace WpfApp3._3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static double Fac(int n)
        {
            double factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Вариант 7
            try
            {
                
               
                    double summa = 0;
                    int n = int.Parse(countBox1.Text);
                    double x = double.Parse(countBox2.Text);
                    for (int i = 0; i < n; i++)
                    {
                    summa += Math.Pow(-1, i) * (Math.Pow(x, i * 2) / Fac(i * 2));
                    }
                    resultBox.Text = $"Сумма {n} рядов = {summa}";
                
               
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}

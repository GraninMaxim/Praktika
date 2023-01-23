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
using System.Windows.Shapes;
using library;

namespace практика
{
    /// <summary>
    /// Логика взаимодействия для zadanie1.xaml
    /// </summary>
    public partial class zadanie1 : Window
    {
        public zadanie1()
        {
            InitializeComponent();
        }

        private void Reshenie_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = 0;
                int x = Int32.Parse(chislo.Text);
                while (x != 0)
                {
                    i++;
                    x /= 10;
                }
                if (i == 3)
                {
                    Class1 zzz = new Class1();
                    if (zzz.FindFirst(Int32.Parse(chislo.Text)) == 1)
                    {
                        MessageBox.Show("Четное");
                    }
                    else MessageBox.Show("Нечетное");
                }
                else MessageBox.Show("Введите трёхзначное число");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Reference_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ввести трёхзначное число. Определить: начинается ли оно чётной цифрой."); 
        }
    }
}

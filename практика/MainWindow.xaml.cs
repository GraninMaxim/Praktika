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

namespace практика
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

        private void zad1_Click(object sender, RoutedEventArgs e)
        {
            zadanie1 zad1 = new zadanie1();
            zad1.Show();
        }

        private void zad2_Click(object sender, RoutedEventArgs e)
        {
            zadanie2 zad2 = new zadanie2();
            zad2.Show();
        }

        private void zad3_Click(object sender, RoutedEventArgs e)
        {
            zadanie3 zad3 = new zadanie3();
            zad3.Show();
        }

        private void Spravka_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИСП-31 Гранин Максим");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zadanie4 zad4 = new zadanie4();
            zad4.Show();
        }
    }
}

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
    /// Логика взаимодействия для zadanie3.xaml
    /// </summary>
    public partial class zadanie3 : Window
    {
        public zadanie3()
        {
            InitializeComponent();
        }
        int[] mas;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Diapazon = Int32.Parse(diapazon.Text);

            mas = new int[Diapazon];
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++) mas[i] = random.Next(-10, 10);
            DataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                GridZamena.ItemsSource = VisualArray.ToDataTable(Class1.GetMas(mas)).DefaultView;
            }
            catch
            {

            }
        }
    }
}

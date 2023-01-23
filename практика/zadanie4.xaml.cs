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
    /// Логика взаимодействия для zadanie4.xaml
    /// </summary>
    public partial class zadanie4 : Window
    {
        public zadanie4()
        {
            InitializeComponent();
        }

        int[,] mas;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Row = Int32.Parse(RowBox.Text);
            int Column = Int32.Parse(ColumnBox.Text);

            mas = new int[Row, Column];
            Random random = new Random();
            int rand;
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    rand = random.Next(-10, 10);
                    mas[i, j] = rand;
                }
            }
            DataGrid.ItemsSource = mas.ToDataTable().DefaultView;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Столбец" + Class1.FindNum(mas));
        }
    }
}

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
    /// Логика взаимодействия для zadanie2.xaml
    /// </summary>
    public partial class zadanie2 : Window
    {
        public zadanie2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            int FirstNum = Int32.Parse(box1.Text);
            int SecondNum = Int32.Parse(box2.Text);
            int ThirstNum = Int32.Parse(box3.Text);
            sum = Class1.GetSum(FirstNum, SecondNum, ThirstNum);
            result.Text = sum.ToString();
        }
    }
}

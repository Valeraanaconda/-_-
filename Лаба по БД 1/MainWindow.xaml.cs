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

namespace Лаба_по_БД_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            foreach (char i in point_a.Text)
            {
                if (i >= 'a' && i <= 'z' || i >= 'A' && i <= 'Z' || i >= 'А' && i <= 'я' || i >= 'А' && i <= 'Я')
                {
                    MessageBox.Show("неверное значение\n попробуй ещё раз");
                }
            }
                   
            
            double a = Convert.ToDouble(point_a.Text);//начало отрезка
            int b = Convert.ToInt32(point_b.Text);//конец отрезка
            int size = 11; //кол. точек
            int n = size;
            for (int i = 0; i <= size; i++,n--)
            {
                double x = (b - a) / (n - 1);
                double tan = Math.Tanh(x) * 200/Math.PI;//перевод из градусов в радианы по формуле из интернета
                double value = x * tan - (1 / 3);

                MessageBox.Show(Convert.ToString("шаг N:"+i+"\nЗначение d(x): "+x+"\nЗначение f(x): "+(value)));
            }

            

        }
    }
}

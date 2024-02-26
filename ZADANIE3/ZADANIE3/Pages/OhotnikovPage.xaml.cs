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

namespace ZADANIE3.Pages
{
    /// <summary>
    /// Логика взаимодействия для OhotnikovPage.xaml
    /// </summary>
    public partial class OhotnikovPage : Page
    {
        public OhotnikovPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x, y, z;

            // Считаем значение из первого lineEdit
            string S1 = textBox1.Text;
            //Переведем значение в число
            x = Convert.ToInt32(S1);

            // Считаем значение из второго lineEdit
            string S2 = textBox2.Text;
            // Переведем значение в число
            y = Convert.ToInt32(S2);

            // Посчитаем сумму
            z = x + y;

            // Выведем результат
            textBox3.Text = z.ToString();
        }
    }
}

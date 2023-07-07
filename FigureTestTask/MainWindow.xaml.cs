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

namespace FigureTestTask
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

        private void FigureChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (FigureSelection.SelectedIndex)
            {
                case 0:
                    TestCheck.Text = "Выбран прямоугольник!";
                    break;
                case 1:
                    TestCheck.Text = "Выбран квадрат!";
                    break;
                case 2:
                    TestCheck.Text = "Выбрана окружность!";
                    break;
            }
        }
    }
}

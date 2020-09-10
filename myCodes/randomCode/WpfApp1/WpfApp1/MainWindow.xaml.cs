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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string cond = "Scrieti un program in care schimbati anotimpu in consecutivitate si le printati";

        private enum Anotimpuri
        {
            Iarna,
            Primavara,
            Vara,
            Toamna
        }

        private Anotimpuri AnotCurent;

        public MainWindow()
        {
            InitializeComponent(); 
            TextBox1.Text = cond;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            TextBox2.Clear();

            for (int i = 0; i < 4; i++)
            {
                switch(i)
                {
                    case 0: { AnotCurent = Anotimpuri.Iarna; break; }
                    case 1: { AnotCurent = Anotimpuri.Primavara; break; }
                    case 2: { AnotCurent = Anotimpuri.Vara; break; }
                    case 3: { AnotCurent = Anotimpuri.Toamna; break; }
                }
                TextBox2.Text += AnotCurent.ToString() + "\n";
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            
        }
    }
}

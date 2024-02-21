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

namespace WpfApp11.page
{
    /// <summary>
    /// Логика взаимодействия для PerehodNaStr.xaml
    /// </summary>
    public partial class PerehodNaStr : Page
    {
        public PerehodNaStr()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            manager.MainFrame.Navigate(new DegtyarevPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            manager.MainFrame.Navigate(new LisitsynPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            manager.MainFrame.Navigate(new MakhnachPage());
        }
    }
}

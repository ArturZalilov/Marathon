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

namespace Marathon2021
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();//объект для обращения к содержимому MainWindow

        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenSponsor(object sender, RoutedEventArgs e) //метод для перехода на страницу "я хочу стать спонсором"
        {
            MW.MainFrame.NavigationService.Navigate(new SponsorPage());
        }

        private void OpenInfo(object sender, RoutedEventArgs e) //метод для перехода на страницу "я хочу узнать больше о событии"
        {
            MW.MainFrame.NavigationService.Navigate(new Pages.Information());
        }

        private void OpenRunner(object sender, RoutedEventArgs e) //метод для перехода на страницу "я хочу стать бегуном"
        {
            MW.MainFrame.NavigationService.Navigate(new Pages.CheckRunner());
        }

        private void OpenAutho(object sender, RoutedEventArgs e) //метод для перехода на страницу "авторизации"
        {
            MW.MainFrame.NavigationService.Navigate(new Pages.Authorization());
        }
    }
}

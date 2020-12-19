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

namespace Marathon2021.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdministratorMenu.xaml
    /// </summary>
    public partial class AdministratorMenu : Page
    {
        MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();//объект для обращения к содержимому MainWindow

        public AdministratorMenu()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, RoutedEventArgs e) //обработчик события для кнопки возврата на нужную страницу
        {
            MW.MainFrame.NavigationService.Navigate(new MainPage()); //в окне MainWindow в фрейме MainFrame переключаемся на нужную страницу
        }
    }
}

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
    /// Логика взаимодействия для SponsorPage.xaml
    /// </summary>
    public partial class SponsorPage : Page
    {
        MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();//объект для обращения к содержимому MainWindow

        public SponsorPage()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, RoutedEventArgs e) //обработчик события для кнопки возврата на нужную страницу
        {
            MW.MainFrame.GoBack(); //возвращаемся на страницу вызываемую ранее
        }

        private void Button_pay_Click(object sender, RoutedEventArgs e) //обработчик события для кнопки оплаты спонсорства
        {
            MW.MainFrame.NavigationService.Navigate(new Pages.ThanksPay(tbMoney.Text)); //вызываем нужную страницу и передаем в ее конструктор значение введенное в поле суммы
        }
    }
}

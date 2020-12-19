using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault(); //объект для обращения к содержимому MainWindow
        MarathonEntities db = new MarathonEntities(); //создаем экземпляр класса нашей БД для обращения к таблицам и их содержимому

        public Authorization()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, RoutedEventArgs e) //обработчик события для кнопки возврата на нужную страницу
        {
            MW.MainFrame.NavigationService.Navigate(new MainPage()); //в окне MainWindow в фрейме MainFrame переключаемся на нужную страницу
        }

        private void AuthorizationClick(object sender, RoutedEventArgs e) //метод для авторизации
        {
            try //блок обработчика ошибки при авторизации
            {
                var user = (from i in db.User
                           where i.Email == tbEmail.Text && i.Password == tbPassword.Text
                           select i).FirstOrDefault(); //получаем первую запись зарегестрированных пользователей из тех, что удовлетворяют условию
                if (user == null) //если записи отсутствуют, выводится сообщение
                    MessageBox.Show("Данный пользователь незарегистрирован!", "Предупреждение");
                else //если присутствуют записи удовлетворяющие условия запроса
                {
                    if (user.RoleId == "A") //проверка роли пользователя и открытие соответствующего его роли меню
                        MW.MainFrame.NavigationService.Navigate(new Pages.AdministratorMenu());
                    else if (user.RoleId == "C")
                        MW.MainFrame.NavigationService.Navigate(new Pages.CoordinatorMenu());
                    else if (user.RoleId == "R")
                        MW.MainFrame.NavigationService.Navigate(new Pages.RunnerMenu());
                }
            }
            catch //что принять в случае возникновения ошибки
            {
                MessageBox.Show("При авторизации возникла ошибка!", "Ошибка"); //вывод сообщения об ошибке
            }
        }
    }
}

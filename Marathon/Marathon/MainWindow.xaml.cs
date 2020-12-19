using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged //наследуем интефрейс INotifyPropertyChanged для уведомления о произошедших изменениях свойств
    {
        public string Time //свойства класс для возвращения оставшегося времени до начала марафона
        {
            get //блок возвращаемого значения
            {
                DateTime dt1 = DateTime.Now; //инициализируем сегодняшние дату и время
                DateTime dt2 = DateTime.Parse("2021-10-21 6:00"); //преобразуем строковое значение даты начала марафона

                TimeSpan ts = dt2 - dt1; //вычисляем разницу в датах для определения оставшегося времени до начала марафона

                return string.Format("{0} дн {1} ч и {2} мин до старта марафона", ts.Days, ts.Hours, ts.Minutes); //возвращаем оставшееся время
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged; //делегат для обработки события PropertyChanged

        private void Window_Loaded(object sender, RoutedEventArgs e) //событие загрузки окна
        {
            Timer tmr = new Timer(); //создаем экземпляр класса Timer для запуска действия спустя какое-то время
            tmr.Interval = 1000; //интервал, через который будет срабатывать определенное действие
            tmr.Elapsed += Tmr_Elapsed; //вызываем метод по истечению времени интервала инициализированного выше

            tmr.Start(); //запуск таймера
        }

        private void Tmr_Elapsed(object sender, ElapsedEventArgs e) //метод вызываемый таймером по истечению времени интервала
        {
            PropertyChange("Time"); //вызываем метод и передаем аргумент
        }

        private void PropertyChange(string name) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name)); //sыполняеv делегат в том потоке, которому принадлежит базовый дескриптор окна элемента управления (обновление значения свойства Time по прошествию времени таймера)
        }
    }
}

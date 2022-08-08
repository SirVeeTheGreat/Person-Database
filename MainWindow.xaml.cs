
using Person__DB.View;
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
using System.Windows.Threading;

namespace Person__DB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StartClock();
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DatabaseView db = new DatabaseView();

            db.Show();

           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPerson person = new AddPerson();

            person.Show();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UpdatePerson up = new UpdatePerson();

            up.Show();
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RemovePerson rm =  new RemovePerson();

            rm.Show();
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
        }

        private void StartClock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += tickevent;
            timer.Start();

        }

        private void tickevent (object sender , EventArgs e)
        {
            lbltime.Content = DateTime.Now.ToString(@"h\mm\:ss");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}

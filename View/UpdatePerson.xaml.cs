using Person__DB.BL.Classes;
using Person__DB.DAL;
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
using System.Windows.Shapes;

namespace Person__DB.View
{
    /// <summary>
    /// Interaction logic for UpdatePerson.xaml
    /// </summary>
    public partial class UpdatePerson : Window
    {
        public UpdatePerson()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PersonBL pBL = new PersonBL("SQLiteProvider");
            Person person = new Person();
            int rc;
            try
            {
                rc = pBL.Update(new Person(txtID.Text, Convert.ToInt32(txtAge.Text), txtname.Text, txtlast.Text));

                if(rc == 0 )
                {
                    MessageBox.Show($"ID  {txtID.Text} has been Updated", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show($"ID  {txtID.Text} already in the database", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

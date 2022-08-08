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
    /// Interaction logic for AddPerson.xaml
    /// </summary>
    public partial class AddPerson : Window
    {
        public AddPerson()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Person person = new Person();
            PersonBL pBL = new PersonBL("SQLiteProvider");
            int rc = 0;



            try
            {
                rc = pBL.Insert(new Person(txtid_2.Text, Convert.ToInt32(txtage_2.Text) , (txtname_2.Text) , txtlast_2.Text));
                
                if (rc == -1)
                {
                    MessageBox.Show("Person Not Added To Database Since Their Already In The Database" , "Information" , MessageBoxButton.OK , MessageBoxImage.Information);
                    txtid_2.Clear();
                    txtname_2.Clear();
                    txtage_2.Clear();
                    txtlast_2.Clear();
                    txtid_2.Focus();
                }
                else
                {
                    MessageBox.Show("Person Added To Database", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtid_2.Clear();
                    txtname_2.Clear();
                    txtage_2.Clear();
                    txtlast_2.Clear();
                    txtid_2.Focus();

                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nTry Again!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                
                
                txtage_2.Clear();
                
                txtage_2.Focus();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

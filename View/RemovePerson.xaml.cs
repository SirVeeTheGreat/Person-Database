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
    /// Interaction logic for RemovePerson.xaml
    /// </summary>
    public partial class RemovePerson : Window
    {
        public RemovePerson()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PersonBL pBL = new PersonBL("SQLiteProvider");
            int rc;
            try
            {
                rc = pBL.Delete(txtboxdelete.Text);
                if (rc == 0)
                {
                   
                    MessageBox.Show($"ID: {txtboxdelete.Text} removed from database");

                }
                else
                {
                    MessageBox.Show($"ID: {txtboxdelete.Text} not found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
  
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

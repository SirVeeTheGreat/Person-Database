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
    /// Interaction logic for DatabaseView.xaml
    /// </summary>
    public partial class DatabaseView : Window
    {
        public DatabaseView()
        {
            InitializeComponent();

            radioId.IsChecked = true;

            
            PersonBL pBL = new PersonBL("SQLiteProvider");
            Persons list = new Persons();

            list = pBL.SelectAll();
            if (list.Count > 0)
            {
                int count = 1;

                foreach (Person p in list)
                {
                    listbox_1.Items.Add("(" + count + "). \n" + p);
                    count++;
                }
            }
            else
            {
                listbox_1.Items.Add("  No Records Found In Database");
                
                
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            listbox_1.Items.Clear();
            PersonBL pBL = new PersonBL("SQLiteProvider");
            dynamic person;
            Persons persons;

            if(radioId.IsChecked == true)
            {
                try
                {

                    person = pBL.SelectPerson(txtfind.Text);

                    if (person != null)
                    {


                        listbox_1.Items.Add(person);

                    }
                    else
                    {
                        listbox_1.Items.Add("No Person Found in Record");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioName.IsChecked == true)
            {
                try
                {

                    persons = pBL.SelectPersonByName(txtfind.Text);

                    if (persons.Count > 0)
                    {

                        foreach(var list in persons)
                        {
                            listbox_1.Items.Add(list);
                        }
                       

                    }
                    else
                    {
                        listbox_1.Items.Add("No Person Found in Record");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

                  
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UpdatePerson  update = new UpdatePerson();
          

            update.ShowDialog();

           
        }

 


        private void txtfind_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            listbox_1.Items.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RemovePerson removePerson = new RemovePerson();

            removePerson.ShowDialog();
           

          

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
    }
}

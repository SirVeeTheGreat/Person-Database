using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person__DB.BL.Classes
{
    public class Person
    {


        [Key]public string ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string ID , int age , string name , string lastName)
        {
            this.ID = ID;
            Age = age;
            Name = name;    
            LastName = lastName;
        }

        public Person()
        {
                
        }

        public override string ToString()
        {
            //
            //Name                     :   public override string ToString()
            //Purpose                  :   Displays the instance of class Person
            //
            //Re-use                   :   none
            //Input Parameter          :   none
            //Output Type              :   string 
            //                           - instances of the Person class
            return "ID: - " + ID + "\n" + "\nAge: - " + Age + "\n" + "\nName: - " + Name + "\n" + "\nLast Name: - " + LastName + " \n_____________________________________________________________________________";
        }
    }
}

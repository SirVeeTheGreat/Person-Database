using Person__DB.BL.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person__DB.DAL
{
    public class SQLiteProvider : ProviderBase
    {
        public override int Delete(string ID)
        {
            Person person;
            int check;
            
            {
                using(PersonContext db = new PersonContext())
                {
                    person = db.Persons.FirstOrDefault(p => p.ID.Equals(ID));

                    if(person == null)
                    {
                        check = - 1;
                    }
                    else
                    {
                        db.Persons.Remove(person);
                        db.SaveChanges();
                        check = 0;
                    }

                }
            }
            return check;
        }

        public override int Insert(Person newPerson)
        {
            Person person;
            int check;

            using (PersonContext db = new PersonContext())
            {
                person = db.Persons.FirstOrDefault(p => p.ID.Equals(newPerson.ID));

                if (person == null)
                {
                    db.Persons.Add(newPerson);
                    db.SaveChanges();
                    check = 0;
                }
                else
                {
                    check = -1;
                }
            }
            return check;
        }

        public override Persons SelectAll()
        {
            Persons list ;
            list = new Persons() ;

            using (PersonContext db = new PersonContext())
            {
                foreach (var iteams in db.Persons)
                {
                    list.Add(iteams);
                }
            }

            return list;
        }
            
  

        public override Person SelectPersonByID(string ID)
        {

            
            Person b;
            int check;


            using (PersonContext db = new PersonContext())
            {


                b = db.Persons.FirstOrDefault( p => p.ID.Equals(ID));
                       
                if (b == null)
                {
                    check = -1;
                }    
                else
                {
                    check = 0;
                }
            }

            return b;
        }

        public override Persons SelectPersonByName(string Name)
        {
            Persons persons = new Persons() ;
            
            using(PersonContext db = new PersonContext())
            {
                foreach(Person p in db.Persons)
                {
                    if (p.Name.Equals(Name))
                    {
                        persons.Add(p);
                    }   
                }
            }

            return persons; 
        }

        public override int Update(Person excistingPerson)
        {
            Person person; 
            
            int check ;  

            using (PersonContext db = new PersonContext())
            {
                person = db.Persons.FirstOrDefault(p => p.ID.Equals(excistingPerson.ID));

                if(person == null)
                {
                    check = -1;
                }
                else
                {
                    check = 0;
                }
            }
            return check;
        }
    }
}

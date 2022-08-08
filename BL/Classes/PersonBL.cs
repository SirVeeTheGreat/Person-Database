using Person__DB.BL.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person__DB.DAL
{
    public class PersonBL
    {

        private ProviderBase providerbase;

        public PersonBL (string provider )
        {
            SetUpProviderBase(provider);

        }
        public void SetUpProviderBase (string provider)
        {
            if (provider == "SQLiteProvider")
            {
                providerbase = new SQLiteProvider();
            }
        }

        public int Insert ( Person newPerson)
        {
            return providerbase.Insert(newPerson);
        }

        public Persons SelectAll()
        {
            return providerbase.SelectAll();
        }

        public Person SelectPerson(string ID)
        {
            return providerbase.SelectPersonByID(ID);
        }

        public int Delete(string ID)
        {
            return providerbase.Delete(ID); 
        }
        public int Update(Person excistingPerson)
        {
            return providerbase.Update(excistingPerson);
        }

        public Persons SelectPersonByName(string Name)
        {
            return providerbase.SelectPersonByName(Name);
        }

    }
}

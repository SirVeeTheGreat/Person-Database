using Person__DB.BL.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person__DB.DAL
{
    public abstract class ProviderBase
    {
        abstract public int Insert(Person newPerson);

        abstract public int Update(Person excistingPerson);
        public abstract int Delete(string ID);
        public abstract Person SelectPersonByID(string ID);
        public abstract Persons SelectAll();
        public abstract Persons SelectPersonByName(string Name);
    }
}

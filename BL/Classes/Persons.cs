using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person__DB.BL.Classes
{
    public class Persons :CollectionBase
    {
        public void Add(Person newPerson)
        {
            List.Add(newPerson);
        }
        public void Remove (Person excistingPerson)
        {
            List.Remove(excistingPerson);
        }
        public Person this[int personIndexer]
        {
            get { return (Person)List[personIndexer]; }

            set { List[personIndexer] = value; }
        }


    }
}

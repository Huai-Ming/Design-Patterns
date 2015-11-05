using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.ContactList
{
    public class MobileOwner
    {
        public List<ContactPerson> ContactPersons { set; get; }

        public ContactMemento CreateMemento()
        {
            return new ContactMemento(new List<ContactPerson>(this.ContactPersons));
        }

        public MobileOwner(List<ContactPerson> persons)
        {
            ContactPersons = persons;
        }

        public void RestoreMemento(ContactMemento memento)
        {
            if(memento != null)
            {
                ContactPersons = memento.ContactPersons;
            }
        }

        public void ShowContacts()
        {
            Console.WriteLine(string.Format("There are {0} contacts in this phone.", ContactPersons.Count()));
            foreach (var person in ContactPersons) 
            {
                Console.WriteLine(person.Name + " " + person.MobileNum);
            }
        }
    }
}

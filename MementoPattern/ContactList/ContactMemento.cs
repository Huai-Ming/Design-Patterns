using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.ContactList
{
    public class ContactMemento
    {
        private List<ContactPerson> contactPersons;

        public ContactMemento(List<ContactPerson> contactPersons)
        {
            this.contactPersons = contactPersons;
        }

        public List<ContactPerson> ContactPersons
        {
            get
            {
                return contactPersons;
            }
        }
    }
}

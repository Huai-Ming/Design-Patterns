
using MementoPattern.ContactList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Struture for memento pattern
            //Originator origiator = new Originator();
            //origiator.State = "ON";

            //CareTaker careTaker = new CareTaker();
            //careTaker.Memento = origiator.CreateMemento();

            //origiator.State = "OFF";
            //origiator.SetMemento(careTaker.Memento);

            List<ContactPerson> contactPersons = new List<ContactPerson>()
            {
                new ContactPerson() { Name= "Learning Hard", MobileNum = "123445"},
                new ContactPerson() { Name = "Tony", MobileNum = "234565"},
                new ContactPerson() { Name = "Jock", MobileNum = "231455"}
            };
            MobileOwner owner = new MobileOwner(contactPersons);
            owner.ShowContacts();

            CareTaker careTaker = new CareTaker();
            careTaker.ContactMementos.Add(DateTime.Now.ToString(), owner.CreateMemento());

            //Remove some contacts;
            owner.ContactPersons.RemoveAt(2);
            owner.ShowContacts();

            Thread.Sleep(1000);
            careTaker.ContactMementos.Add(DateTime.Now.ToString(), owner.CreateMemento());

            Console.WriteLine("Restore Date Index:");
            var keyCollections = careTaker.ContactMementos.Keys;
            foreach(var key in keyCollections)
            {
                Console.WriteLine(key);
            }
            while(true)
            {
                int index = -1;
                try
                {
                    index = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("The format is wrong");
                    continue;
                }

                ContactMemento contactMentor = null;
                if (index < keyCollections.Count && careTaker.ContactMementos.TryGetValue(keyCollections.ElementAt(index), out contactMentor))
                {
                    owner.RestoreMemento(contactMentor);
                    owner.ShowContacts();
                }
                else
                {
                    Console.WriteLine("");
                }
            }



            Console.Read();
        }
    }
}

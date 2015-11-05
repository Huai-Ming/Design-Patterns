using BridgePattern.Practical;
using BridgePattern.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //// Structure
            //Abstraction abstraction = new RefinedAbstraction();

            //abstraction.Implementor = new ConcreteImplementorA();
            //abstraction.Operation();

            //abstraction.Implementor = new ConcreteImplementorB();
            //abstraction.Operation();


            //Practical about making coffee;
            MakeCoffee blackCoffee = new BlackCoffee();
            MakeCoffeeSingleton.MakeCoffee = blackCoffee;

            Coffee large = new LargeCupCoffee();
            large.Make();

            Coffee medium = new MediumCupCoffee();
            medium.Make();

            MakeCoffee whiteCoffeee = new WhiteCoffee();
            MakeCoffeeSingleton.MakeCoffee = whiteCoffeee;

            Coffee large1 = new LargeCupCoffee();
            large1.Make();

            Coffee medium1 = new MediumCupCoffee();
            medium1.Make();

            Console.Read();
        }
    }
}

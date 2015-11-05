using FlyweightPattern.Practical;
using FlyweightPattern.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Structure;
            //int extrinsicstate = 22;

            //FlyweightFactory factory = new FlyweightFactory();

            //Flyweight fx = factory.GetFlyweight("X");
            //fx.Operation(--extrinsicstate);

            //Flyweight fy = factory.GetFlyweight("Y");
            //fy.Operation(--extrinsicstate);

            //Flyweight fz = factory.GetFlyweight("Z");
            //fz.Operation(--extrinsicstate);

            //UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            //fu.Operation(--extrinsicstate);


            //Practical
            string document = "AAZZBBZZBB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            int pointSize = 10;

            foreach(char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }


            Console.ReadLine();
        }
    }
}

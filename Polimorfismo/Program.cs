using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        abstract class Accomodation
        {
            public virtual void VisitIt()
            {
                Console.WriteLine("I'm visiting a random accomodation before I buy it");
            }
            public abstract void GoToSecondFloor();
        }
        class Flat : Accomodation
        {
            public new void VisitIt()
            {
                Console.WriteLine("I'm visiting my friend's flat");
            }
            public override void GoToSecondFloor()
            {
                Console.WriteLine("I'm taking the lift");
            }
        }
        class House : Accomodation
        {
            public override void GoToSecondFloor()
            {
                Console.WriteLine("I'm going upstairs");
            }
        }

        static void Main(string[] args)
        {
            Accomodation flat = new Flat();
            Accomodation house = new House();
            flat.GoToSecondFloor();
            flat.VisitIt();
            house.GoToSecondFloor();
            house.VisitIt();

            Console.Read();

        }
    }
}

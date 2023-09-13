using csharp_abstract_animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animal_subclasses
{
    internal class Eagle : Animal, ICanFly
    {
        public override void CosaMangi()
        {
            Console.WriteLine("L'aquila si nutre principalmente di piccoli mammiferi o rettili");
        }

        public override void Verso()
        {
            Console.WriteLine("GHYAAAAAAAAA!!!!!!");

        }

        private void Fly()
        {
            Console.WriteLine("Sto volando!");
        }

        public void StartFlying(ICanFly animal)
        {
            Console.WriteLine("Inizio a volare....");
            Fly();
        }
    }
}

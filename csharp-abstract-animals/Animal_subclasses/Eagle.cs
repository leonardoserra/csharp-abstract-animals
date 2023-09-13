using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animal_subclasses
{
    internal class Eagle : Animal
    {
        public override void CosaMangi()
        {
            Console.WriteLine("L'aquila si nutre principalmente di piccoli mammiferi o rettili");
        }

        public override void Verso()
        {
            Console.WriteLine("GHYAAAAAAAAA!!!!!!");

        }
    }
}

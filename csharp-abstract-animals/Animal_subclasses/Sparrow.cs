using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animal_subclasses
{
    internal class Sparrow : Animal
    {
        public override void CosaMangi()
        {
            Console.WriteLine("Il passerotto si nutre principalmente bacche ed insetti");
        }

        public override void Verso()
        {
            Console.WriteLine("CIP CIP CIPPPP!");
        }
    }
}

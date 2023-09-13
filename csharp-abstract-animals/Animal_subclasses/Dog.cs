using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animal_subclasses
{
    internal class Dog : Animal
    {
        public override void CosaMangi()
        {
            Console.WriteLine("Il cane si nutre principalmente di carne");
        }

        public override void Verso()
        {
            Console.WriteLine("Woof WOOOOFFF!!!");

        }
    }
}

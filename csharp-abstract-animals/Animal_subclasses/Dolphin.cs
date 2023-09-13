using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animal_subclasses
{
    internal class Dolphin : Animal
    {
        public override void CosaMangi()
        {
            Console.WriteLine("Il delfino si nutre principalmente di altri pesci");
        }

        public override void Verso()
        {
            Console.WriteLine("KKKkk kk k kKK kK kKK Kk Kkk !");
        }
    }
}

using csharp_abstract_animals.Animal_subclasses;
using csharp_abstract_animals.Interfaces;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cane = new Dog();
            cane.CosaMangi();
            cane.Dormi();
            cane.Verso();
            Console.WriteLine();

            Animal passerotto = new Sparrow();
            passerotto.CosaMangi();
            passerotto.Dormi();
            ICanFly passerottoVolante = new Sparrow();
            passerottoVolante.StartFlying(passerottoVolante);
            passerotto.Verso();
            Console.WriteLine();


            Animal aquila = new Eagle();
            aquila.CosaMangi();
            aquila.Dormi();
            aquila.Verso();
            ICanFly aquilaVolante= new Eagle();
            aquilaVolante.StartFlying(aquilaVolante);
            Console.WriteLine();


            Animal delfino = new Dolphin();
            delfino.CosaMangi();
            delfino.Dormi();
            delfino.Verso();
            ICanSwim delfinoNuotatore = new Dolphin();
            delfinoNuotatore.StartSwimming(delfinoNuotatore);
            Console.WriteLine();

        }
    }
}
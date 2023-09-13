﻿using csharp_abstract_animals.Animal_subclasses;


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
            passerotto.Verso();
            Console.WriteLine();


            Animal aquila = new Eagle();
            aquila.CosaMangi();
            aquila.Dormi();
            aquila.Verso();
            Console.WriteLine();

        }
    }
}
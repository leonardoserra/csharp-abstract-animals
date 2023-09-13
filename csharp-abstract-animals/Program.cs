using csharp_abstract_animals.Animal_subclasses;
using csharp_abstract_animals.Interfaces;

namespace csharp_abstract_animals
{

    //come estendere un method in una classe senza inserirlo dentro la classe stessa
    public static class Extensions
    {
        //estensione di method
        public static void Corri(this Animal animal)
        {
            Console.WriteLine("L'animale corre");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            //esempio di generic tuple
            List<(int, double)> ciao = new List<(int, double)>();
            (double, int numero2) asd = (2.0, 3);
            asd.Item1 = 3;


            //applico un metodo esteso //public static void Corri(this Animal animal)
            Animal caneEsteso = new Dog();
            
            Extensions.Corri(caneEsteso);//modo normale e non immediato
            caneEsteso.Corri();//syntatic sugar usando il this nella firma

            Animal cane = new Dog();
            cane.CosaMangi();
            cane.Dormi();
            cane.Verso();
            Console.WriteLine();

          

            Animal passerotto = new Sparrow();
            passerotto.CosaMangi();
            passerotto.Dormi();
            ICanFly passerottoVolante = new Sparrow();
            passerottoVolante.Fly();
            passerotto.Verso();
            Console.WriteLine();
            ICanFly prova = null;

            



            Animal aquila = new Eagle();
            aquila.CosaMangi();
            aquila.Dormi();
            aquila.Verso();
            ICanFly aquilaVolante= new Eagle();
            aquilaVolante.Fly();
            Console.WriteLine();


            Animal delfino = new Dolphin();
            delfino.CosaMangi();
            delfino.Dormi();
            delfino.Verso();
            ICanSwim delfinoNuotatore = new Dolphin();
            delfinoNuotatore.Swim();
            Console.WriteLine();

        }
    }
}
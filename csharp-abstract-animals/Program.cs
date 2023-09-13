using csharp_abstract_animals.Animal_subclasses;


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

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            Specie hundSpecie = new Specie("Hund", 2, 4);
            Pet  karlsPet   = new Pet(hundSpecie, "Rofus");
            Person karl = new Person("Karl", 1990, karlsPet);

            Console.WriteLine(karl.Name);
            Console.WriteLine(karl.SpecieName.PetName);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

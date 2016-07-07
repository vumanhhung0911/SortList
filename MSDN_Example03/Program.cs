using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSDN_Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dinosaurs = new List<string>();

            dinosaurs.Add("Pachycephalosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");

            Console.WriteLine("List before sorted.");
            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
                Console.WriteLine(dinosaur);

            dinosaurs.Sort();
            Console.WriteLine("\nList after sorted.");
            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
                Console.WriteLine(dinosaur);

            Console.WriteLine("\nBinarySearch and Insert \"Coelophysis\":");
            int index = dinosaurs.BinarySearch("Coelophysis");
            if (index < 0) dinosaurs.Insert(~index, "Coelophysis");

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
                Console.WriteLine(dinosaur);

            Console.WriteLine("\nBinarySearch and Insert \"Tyrannosaurus\":");
            int index2 = dinosaurs.BinarySearch("Tyrannosaurus");
            if (index < 0) dinosaurs.Insert(~index2, "Tyrannosaurus");

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
                Console.WriteLine(dinosaur);

            Console.Read();
        }
    }
}

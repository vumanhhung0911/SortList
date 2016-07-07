using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortList
{
    /*The following example adds some names to a List<String> object, 
    displays the list in unsorted order, calls the Sort method,
    and then displays the sorted list.*/
    class Program
    {
        static void Main(string[] args)
        {
            String[] names = {"Samuel", "Dakota", "Koani", "Saya", "Vanya",
                         "Yiska", "Yuma", "Jody", "Nikita" };
            var nameList = new List<String>();
            nameList.AddRange(names);
            Console.WriteLine(Environment.NewLine);
            nameList.Sort();
            Console.WriteLine("List in sorted order: ");
            foreach (var name in nameList)
                Console.Write("   {0}", name);

            Console.WriteLine();
            Console.Read();
        }
    }
}

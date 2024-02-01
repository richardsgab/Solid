using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*MultiFuncionDevice multifndev = new MultiFuncionDevice();
            multifndev.Print();
            multifndev.Fax();
            multifndev.Scan();*/

            Printer print = new Printer();
            print.Print();
            Scanner scanner = new Scanner();
            scanner.Scan();
            

            AllPossible allPossible = new AllPossible();
            allPossible.Print();
            allPossible.Scan();
        }
    }
}

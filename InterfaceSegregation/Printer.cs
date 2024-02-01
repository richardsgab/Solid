using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Printer : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Printing"); 
        }

        void IPrint.Print()
        {
            throw new NotImplementedException();
        }
    }
}

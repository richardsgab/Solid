using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class MultiFuncionDevice : IMultiFunctionDevice
    {
        public void Fax()
        {
            Console.WriteLine("Faxing from MultiFnDevice"); 
        }

        public void Print()
        {
            Console.WriteLine("Printing from MultiFnDevice");
        }

        public void Scan()
        {
            Console.WriteLine("Scaning from MultiFnDevice");
        }
    }
}

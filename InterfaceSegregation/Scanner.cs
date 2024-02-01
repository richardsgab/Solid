using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Scanner : IScan
    {
        public void Scan()
        {
            Console.WriteLine("Scanning");
        }

        void IScan.Scan()
        {
            throw new NotImplementedException();
        }
    }
}

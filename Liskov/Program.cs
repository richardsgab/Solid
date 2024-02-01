using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voertuig voertuig = new Voertuig();            
            Auto auto = new Auto();

            Voertuig vauto = new Auto();


            Test test = new Test();
            test.StartVoertuig(voertuig);
            test.StartVoertuig(auto);//this line is Liskov substitution
            test.StartVoertuig(vauto);//this line is Liskov substitution
        }
    }
}

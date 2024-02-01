using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Auto:Voertuig
    {
        public override void Start()
        {
            Console.WriteLine(" Auto is gestart  rrrannn"); 
        }
    }
}

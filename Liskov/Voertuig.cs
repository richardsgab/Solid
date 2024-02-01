using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Voertuig
    {
        public virtual void Start()
        {
            Console.WriteLine("Voertuig broummmm");
        }
    }
}

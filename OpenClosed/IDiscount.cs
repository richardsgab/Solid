using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal subtotal);
    }
}

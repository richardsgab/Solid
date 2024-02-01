using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class Invoice
    {
        

        public decimal Subtotal { get; set; }
        private readonly IDiscount discountStrategy;//is private because the interface

        //this ctor is for implement the interface:
        public Invoice(IDiscount discountStrategy)
        { 
            this.discountStrategy = discountStrategy;
        }
        public decimal GetTotal()
        {
            return discountStrategy.ApplyDiscount(Subtotal);
        }
    }
}

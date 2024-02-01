using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class PremiumDiscount : IDiscount
    {
        DateTime vandaag;

        public PremiumDiscount()
        {
            vandaag = DateTime.Now.AddDays(1);
        }
        public decimal ApplyDiscount(decimal subtotal)
        {
            if (IsJanuariOfFebruary(vandaag))
            {
                return subtotal - (subtotal * 0.20m);//20% korting
            }
            else 
            { 
                return subtotal - (subtotal * 0.01m); //10% korting
            }
        }
        public bool IsJanuariOfFebruary(DateTime vandaag) 
        { 
            if(vandaag.Month == 1 || vandaag.Month == 2) 
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}

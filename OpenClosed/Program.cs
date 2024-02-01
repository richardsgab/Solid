using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Invoice> list = new List<Invoice>();
            
            var standardInvoice = new Invoice(new StandartDiscount());
            standardInvoice.Subtotal = 100;
            Console.WriteLine(standardInvoice.GetTotal());
            list.Add(standardInvoice);

            var premiumInvoice = new Invoice(new PremiumDiscount());
            premiumInvoice.Subtotal = 100;
            Console.WriteLine(premiumInvoice.GetTotal());
            list.Add(premiumInvoice);

            Console.WriteLine("List");
            foreach (var item in list) 
            {
                Console.WriteLine($"{item.Subtotal} {item.GetTotal()}");
            }
        }
    }
}

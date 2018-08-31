// CIS214 Midterm: Let's get it!
using System;

namespace CIS214_Midterm2_Odden
{
    class Invoice
    {
        // static variables
        public static int instanceCount = 0;
        public static decimal invoiceTotal = 0;

        // automatic properties for Invoice instance
        public int Id { get; set; } // random id for part
        public string PartNumber { get; set; } // part number
        public string PartDescription { get; set; } // part description
        public int Quantity { get; set; } // quantity of said part
        public decimal Price { get; set; } // price of said part

        // calculates the invoice amount
        public void GetInvoiceAmount()
        {
            decimal amount; // total price for quantity of part

            // total amount equals quantity times price
            amount = Quantity * Price;

            // display total amount
            Console.WriteLine("Total amount for this invoice is: {0:C}", amount);

            invoiceTotal = invoiceTotal + amount;
        }

        // print totals
        public static void GetInvoiceTotal()
        {
            // Total Count of Objects
            Console.WriteLine("\n**** Total number of invoices created:\t{0}", Invoice.instanceCount);
            // Display final invoice total amount
            Console.WriteLine("**** Total amount for all invoices is:\t{0:C}\n", Invoice.invoiceTotal);
        }
    }
}
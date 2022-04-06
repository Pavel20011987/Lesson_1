using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Lesson2_4
    {
        static void Main(string[] args)
        {
            Invoice cust1 = new Invoice("Customer-1");
            InvoiceLineItem item1 = new InvoiceLineItem(83, "Electric Sander", 7, 57.98m);
            InvoiceLineItem item2 = new InvoiceLineItem(24, "Power Saw", 18, 99.99m);
            InvoiceLineItem item3 = new InvoiceLineItem(7, "Sledge Hammer", 11, 21.50m);
            cust1.AddLineItem(item1);
            cust1.AddLineItem(item2);
            cust1.AddLineItem(item3);

            Invoice cust2 = new Invoice("Customer-2");
            InvoiceLineItem item4 = new InvoiceLineItem(77, "Hammer", 76, 11.99m);
            InvoiceLineItem item5 = new InvoiceLineItem(39, "Lawn Mower", 3, 79.50m);
            InvoiceLineItem item6 = new InvoiceLineItem(68, "Screwdriver", 106, 6.99m);
            cust2.AddLineItem(item4);
            cust2.AddLineItem(item5);
            cust2.AddLineItem(item6);

            Console.WriteLine(cust1.ToString());
            Console.WriteLine(cust2.ToString());

            Console.ReadLine();
        }
        class Invoice
        {
            public string CustomerName { get; set; }
            public decimal InvoiceTotal { get; set; }

            List<InvoiceLineItem> InvoiceLineItems = new List<InvoiceLineItem>();

            public Invoice()
            {

            }

            public Invoice(string customerName)
            {
                this.CustomerName = customerName;
            }

            public void AddLineItem(InvoiceLineItem item)
            {
                InvoiceLineItems.Add(item);
            }

            public override string ToString()
            {
                string result = "Product Number\tDescription\tQuantity\tPrice Per Unit\n" + CustomerName + "\n";
                foreach (InvoiceLineItem item in InvoiceLineItems)
                    result += (item.ProductNumber + "\t\t" + item.ProductDescription + "\t" + item.Quantity + "\t\t" + item.PricePerUnit.ToString() + "\n");

                return result;
            }
        }

        class InvoiceLineItem
        {
            public int ProductNumber { get; set; }
            public string ProductDescription { get; set; }
            public int Quantity { get; set; }
            public decimal PricePerUnit { get; set; }
            public decimal ExtendedPrice { get; set; }

            public InvoiceLineItem()
            {

            }

            public InvoiceLineItem(int productNumber, string productDescription, int quantity, decimal pricePerUnit)
            {
                this.ProductNumber = productNumber;
                this.ProductDescription = productDescription;
                this.Quantity = quantity;
                this.PricePerUnit = pricePerUnit;
                this.ExtendedPrice = pricePerUnit * quantity;
            }
        }
    }
}

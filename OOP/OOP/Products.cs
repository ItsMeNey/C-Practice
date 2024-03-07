using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Products
    {
        public String pName;
        public String pDesc;
        public int productID;
        public float price;
        public int quantity;

        public Products(string pName, string pDesc, int productID, float price, int quantity)
        { 
            this.pName = pName;
            this.pDesc = pDesc; 
            this.productID = productID; 
            this.price = price;
            this.quantity = quantity;

            Console.WriteLine("The product he like is " + pName);
            Console.WriteLine("The type of the shoes is " + pDesc);
            Console.WriteLine("The product ID is " +productID);
            Console.WriteLine("The price is " + price+"$");
            Console.WriteLine("Available product: " + quantity+"pcs");
            Console.WriteLine();
        }
    }
}

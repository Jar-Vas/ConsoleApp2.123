using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Money
    {
        public decimal _Money { get; set; }

        public Money(decimal money) { _Money = money; }
        public Money() { _Money = (decimal) 0; }

        public string Info()
        {
            Console.Write(_Money);
            return _Money.ToString();
        }
    }

    internal class  Product : Money
    {
        public string Product_name { get; set; }

        public Product(string product_name, decimal prise) : base(prise) { Product_name = product_name; }
        public Product(string product_name) : base() { Product_name = product_name; }
        public Product() : base() { Product_name = ""; }

        public void Product_info() { Console.WriteLine("Product: " + Product_name + " , prise: " + _Money); }

        public void Add_prise(decimal amount) { _Money += amount; }
        public void Substract_prise(decimal amount) { _Money -= amount; }

        static public Product operator+(Product a, decimal b) { return new Product(a.Product_name, a._Money + b); }
        static public Product operator -(Product a, decimal b) { return new Product(a.Product_name, a._Money - b); }
    }
}

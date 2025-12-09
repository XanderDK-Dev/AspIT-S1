using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBasics
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created {  get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Created: {Created}, Price: {Price}";
        }
    }
}

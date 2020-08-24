using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioPropostoHerancaePolimorfismo.Entities
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; protected set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return $"{Name} ${ Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

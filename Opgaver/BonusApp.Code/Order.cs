using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        private List<Product> _products = new List<Product>();
        public delegate T Operation<T>(T amount);
        public BonusProvider Bonus { get; set; }

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }
        public double GetValueOfProducts()
        {
            double valueOfProducts = 0.0;

            foreach (Product p in _products)
            {
                valueOfProducts += p.Value;
            }

            return valueOfProducts;
        }
        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }
        public double GetBonus(Operation<double> amount)
        {
            Func<double, double> bonus = x =>
            {
                foreach (Product p in _products)
                {
                    x += p.Value;
                }
                return x;
            };
            return 0;

        }
        public double GetTotalPrice()
        {
            return GetValueOfProducts()-GetBonus();
        }
    }
}

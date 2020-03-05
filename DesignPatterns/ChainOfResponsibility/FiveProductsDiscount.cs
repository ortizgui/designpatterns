using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility
{
    public class FiveProductsDiscount : IDiscount
    {
        public IDiscount NextDiscountRule { get; set; }

        public decimal Apply(List<Product> products)
        {
            if(products.Count >= 5)
            {
                return products.Sum(p => p.Price) * (decimal)0.25;
            }

            return NextDiscountRule.Apply(products);
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility
{
    public class OneProductDiscount : IDiscount
    {
        public IDiscount NextDiscountRule { get; set; }

        public decimal Apply(List<Product> products)
        {
            if(products.Count == 1)
            {
                return products.Sum(p => p.Price) * (decimal)0.1;
            }

            return NextDiscountRule.Apply(products);
        }
    }
}
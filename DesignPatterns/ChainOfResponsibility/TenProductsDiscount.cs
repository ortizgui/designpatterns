using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility
{
    public class TenProductsDiscount : IDiscount
    {
        public IDiscount NextDiscountRule { get; set; }

        public decimal Apply(List<Product> products)
        {
            if(products.Count >= 10)
            {
                return products.Sum(p => p.Price) * (decimal)0.3;
            }

            return NextDiscountRule.Apply(products);
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility
{
    public class NoDiscount : IDiscount
    {
        public IDiscount NextDiscountRule { get; set; }

        public decimal Apply(List<Product> products)
        {
            return 0;
        }
    }
}
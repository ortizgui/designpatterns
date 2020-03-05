using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public interface IDiscount
    {
        IDiscount NextDiscountRule { get; set; }
        decimal Apply(List<Product> products);
    }
}
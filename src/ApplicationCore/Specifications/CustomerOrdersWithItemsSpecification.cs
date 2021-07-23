using ApplicationCore.Entities.OrderAggregate;
using Ardalis.Specification;
using System.Linq;

namespace ApplicationCore.Specifications
{
    public class CustomerOrdersWithItemsSpecification : Specification<Order>
    {
        public CustomerOrdersWithItemsSpecification(string buyerId)
        {
            Query.Where(o => o.BuyerId == buyerId)
                .Include(o => o.OrderItems)
                .ThenInclude(i => i.ItemOrdered);
        }
    }
}

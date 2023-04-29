using System.Collections.Generic;
using System.Linq;

namespace Olive.Porcupine.Domain.Orders
{

    public class Order
    {
        public int Id {get; set;}
        public List<OrderItem> Items {get; set;} =null!;
        public DateTime CreatedDate {get; set;}
        public decimal TotalPrice => Items.Sum(i => i.Price);
    }
}
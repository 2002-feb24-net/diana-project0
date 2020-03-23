using System;
using System.Collections.Generic;

namespace DataBaseConnection.Model
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? LocationId { get; set; }
        public int? OrderTotal { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.Shared
{
    public class OrderDetails
    {
        // public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId  { get; set; }
        public int Cuantity { get; set; }
    }
}

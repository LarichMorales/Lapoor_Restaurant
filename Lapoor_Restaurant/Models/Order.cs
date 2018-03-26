using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lapoor_Restaurant.Domain.Enums;
using Lapoor_Restaurant.Domain.Infrastructure;

namespace Lapoor_Restaurant.Domain.Model
{
    public class Orders : BaseModel
    {
        public decimal OrderNo { get; set; }
        public decimal TableNo { get; set; }
        public OrderStatus Status { get; set; }
        public bool Paid { get; set; }
    }
}
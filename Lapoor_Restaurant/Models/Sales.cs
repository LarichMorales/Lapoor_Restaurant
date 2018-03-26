using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lapoor_Restaurant.Domain.Infrastructure;

namespace Lapoor_Restaurant.Domain.Model
{
    public class Sales : BaseModel
    {
        public Guid? OrderId { get; set; }
        public int CashTenderd { get; set; }
        public DateTime date { get; set; }

    }
}
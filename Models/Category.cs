using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lapoor_Restaurant.Domain.Infrastructure;

namespace Lapoor_Restaurant.Domain.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }

        public Guid? ParentId { get; set; }
    }
}

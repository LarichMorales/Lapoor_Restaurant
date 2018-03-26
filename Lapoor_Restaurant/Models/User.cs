using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lapoor_Restaurant.Domain.Infrastructure;
using Lapoor_Restaurant.Domain.Models.Enums;

namespace Lapoor_Restaurant.Domain.Models
{
    public class User : BaseModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        internal static object ByUserName(string text)
        {
            throw new NotImplementedException();
        }
    }
}
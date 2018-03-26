using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lapoor_Restaurant.Domain.Enums;
using Lapoor_Restaurant.Domain.Insfrastructure;
using Lapoor_Restaurant.Domain.Model;
using Lapoor_Restaurant.BLL;

namespace walangforeverRestaurant.Domain.BLL
{
    public class MaterialBLL
    {
        private static DataAccess db = new DataAccess();

        public static List<Materials> GetAll()
        {
            return db.Materials.ToList();
        }

        public static Materials SearchByName(string name)
        {
            return db.Materials.FirstOrDefault(m => m.Name == name);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lapoor_Restaurant.Domain.BLL
{
    internal class DataAccess
    {
        internal object Materials;

        public object Categor { get; internal set; }
        public object Category { get; internal set; }
        public object Products { get; internal set; }
        public IQueryable<Category> Categories { get; internal set; }
        public object Users { get; internal set; }
        public object Deliveries { get; internal set; }
        public object DeliveryItems { get; internal set; }
        public object Delivery { get; internal set; }
        public object DeliveryItem { get; internal set; }

        internal List<User> ToList()
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
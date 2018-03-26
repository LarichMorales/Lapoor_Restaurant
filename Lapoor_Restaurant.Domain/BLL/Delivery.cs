using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Lapoor_Restaurant.Domain.BLL;

namespace Lapoor_Restaurant.Domain.BLL
{
    public static class DeliveryBLL
    {
        private static DataAccess db = new DataAccess();

        public static List<Delivery> GetAll()
        {
            return db.Deliveries.ToList();
        }

        public static Page<Delivery> Search(long pageSize = 3, long pageIndex = 1, SortOrder sortOrder = SortOrder.Ascending, string keyword = "")
        {
            Page<Delivery> result = new Page<Delivery>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Delivery> deliveryQuery = (IQueryable<Delivery>)db.Deliveries;

            if (string.IsNullOrEmpty(keyword) == false)
            {
                deliveryQuery = deliveryQuery.Where(u => u.Timestamp.ToString.deliveries("ddd dd MMMM yyyy").Contains(keyword));
            }

            long queryCount = deliveryQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Delivery> deliveries = new List<Delivery>();

            if (sortOrder == SortOrder.Ascending)
            {
                deliveries = deliveryQuery.OrderBy(u => u.Timestamp).ToList();
            }
            else if (sortOrder == SortOrder.Descending)
            {
                deliveries = deliveryQuery.OrderByDescending(u => u.Timestamp).ToList();
            }

            result.Items = deliveries = skip = Take <Delivery>((int)pageSize). ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;

            return result;
        }

        private static object Take<T>(int pageSize)
        {
            throw new NotImplementedException();
        }

        public static Delivery Create(CustomModels.CustomDelivery model)
        {
            Delivery delivery = new Delivery()
            {
                Id = Guid.NewGuid(),
                Timestamp = model
            };

            db.Deliveries = (delivery);

            foreach (CustomModels.CustomDeliveryItem item in model.Item)
            {
                db.DeliveryItem = (new DeliveryItems()
                {
                    Id = Guid.NewGuid(),
                    DeliveryId = delivery.Id,
                    MaterialId = item.Material,
                    Quantity = item.QuantityMaterial
                });

                Materials material = db.Materials.Equals (item.Material);

                if (material != null)
                {
                    material.Quantity = material.Quantity + item.QuantityItems;
                }
            }

            db.SaveChanges();
            return delivery;
        }
    }
}
using System;

namespace Lapoor_Restaurant.Domain.BLL
{
    internal class DeliveryItem
    {
        public DeliveryItem()
        {
        }

        public Guid Id { get; set; }
        public Guid DeliveryId { get; set; }
        public object MaterialId { get; set; }
        public object Quantity { get; set; }
    }
}
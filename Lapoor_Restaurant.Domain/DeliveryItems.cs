using System;

namespace Lapoor_Restaurant.Domain.BLL
{
    internal class DeliveryItems
    {
        public DeliveryItems()
        {
        }

        public Guid Id { get; set; }
        public object DeliveryId { get; set; }
        public object MaterialId { get; set; }
        public object Quantity { get; set; }
    }
}
using System.Collections.Generic;

namespace Lapoor_Restaurant.Domain.CustomModels
{
    public class CustomDelivery
    {
        public CustomDelivery()
        {
        }

        public object Date { get; internal set; }
        public IEnumerable<CustomDeliveryItem> ItemsI { get; internal set; }
        public IEnumerable<CustomDeliveryItem> Item { get; internal set; }
        internal IEnumerable<CustomDeliveryItem> Items { get; set; }
    }
}
using System;
using Lapoor_Restaurant.Domain.CustomModels;

namespace walangforeverRestaurant.Domain.BLL
{
    public class Materials
    {
        public CustomDeliveryItem.Quantity Quantity { get; internal set; }

        public static implicit operator Materials(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
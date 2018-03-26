namespace Lapoor_Restaurant.Domain.CustomModels
{
    internal class CustomDeliveryItem
    {
        public object Quantity { get; internal set; }
        public object MaterialId { get; internal set; }
        public object Material { get; internal set; }
        public object QuantityMaterial { get; internal set; }
        public CustomDeliveryItem.Quantity QuantityItems { get; internal set; }

        public class Quantity
        {
        }
    }
}
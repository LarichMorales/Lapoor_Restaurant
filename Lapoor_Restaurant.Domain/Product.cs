using System;

namespace Lapoor_Restaurant.Domain.BLL
{
    public class Product
    {
        public Guid CategoryId { get; internal set; }
        public object UserName { get; internal set; }
        public object User { get; internal set; }
        public object Name { get; internal set; }
        public object ParentId { get; internal set; }
    }
}
using System;

namespace Lapoor_Restaurant.Domain.BLL
{
    public class Category
    {
        public object Parent { get; internal set; }
        public object NameofParent { get; internal set; }
        public Guid NameofParentId { get; internal set; }
        public object ParentId { get; internal set; }
        public object Name { get; internal set; }
    }
}
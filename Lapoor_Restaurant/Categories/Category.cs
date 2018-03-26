using System;

namespace Lapoor_Restaurant.POS.Categories
{
    internal class Category
    {
        public Guid? ParentId { get; internal set; }
        public string Name { get; internal set; }
    }
}
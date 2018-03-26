using System;

namespace Lapoor_Restaurant.Domain.Models
{
    public class Category
    {
        public Guid Id { get; internal set; }
        public Guid ParentId { get; internal set; }
        public string Name { get; internal set; }
    }
}
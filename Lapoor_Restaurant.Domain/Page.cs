using System.Collections.Generic;

namespace Lapoor_Restaurant.Domain.BLL
{
    public class Page<T>
    {
        public List<Category> Items { get; internal set; }
        public int PageCount { get; internal set; }
        public long PageSize { get; internal set; }
        public long QueryCount { get; internal set; }
    }
}
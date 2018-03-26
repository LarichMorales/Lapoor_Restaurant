using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lapoor_Restaurant.Domain.BLL
{
    public static class CategorBLL
    {
        private static DataAccess db = new DataAccess();

        public static List<Category> All;

        private static void ToList<T>()
        {
            throw new NotImplementedException();
        }

        public static Page<Category> Search(long pageSize = 3, long pageIndex = 1, SortOrder sortOrder = SortOrder.Ascending, string keyword = "", Guid? parentId = null)
        {
            Page<Category> result = new Page<Category>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Category> catQuery = (IQueryable<Category>)db;

            if (parentId != null)
            {
                catQuery = catQuery.Where(c => c.NameofParentId == parentId.Value);
            }
            else
            {
                catQuery = catQuery.Where(c => c.NameofParentId == null);
            }

            if (string.IsNullOrEmpty(keyword) == false)
            {
                catQuery = catQuery.Where(c =>Contains(keyword));
            }

            long queryCount = catQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Category> categories = new List<Category>();

            if (sortOrder == SortOrder.Ascending)
            {
                categories = catQuery.OrderBy(c => c.NameofParent).ToList();
            }
            else
            {
                categories = catQuery.OrderByDescending(u => u.NameofParent).ToList();
            }


            result.Items = categories.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;

            return result;
        }

        private static bool Contains(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
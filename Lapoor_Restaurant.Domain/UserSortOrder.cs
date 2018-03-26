namespace Lapoor_Restaurant.Domain.BLL
{
    public class UserSortOrder
    {
        internal const UserSortOrder UserName;

        public static UserSortOrder FirstName { get; internal set; }
        public static UserSortOrder LastName { get; internal set; }
    }
}
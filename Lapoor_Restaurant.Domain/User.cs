using System;

namespace Lapoor_Restaurant.BLL
{
    public class User
    {
        public object LastName { get; internal set; }
        public object UserName { get; internal set; }
        public object FirstName { get; internal set; }
        public object Role { get; internal set; }
        public Guid? Id { get; internal set; }
    }
}
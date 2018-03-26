using System;

namespace Insfrastructure
{
    internal class DataAccess
    {
        public object Orders { get; internal set; }
        public object Product { get; internal set; }
        public object Users { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
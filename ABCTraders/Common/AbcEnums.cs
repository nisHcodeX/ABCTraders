using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Common
{
    internal class AbcEnums
    {
        public enum UserTypes
        {
            Customer = 0,
            Admin = 1,
        }
        public enum FuelTypes
        {
            Petrol = 0,
            Diesel = 1,
            Electric = 2,
        }
        public enum CarCondition
        {
            BrandNew = 0,
            Used = 1,
        }

        public enum CarStatus
        {
            Available = 0,
            Pending = 1,
            Approved = 2,
            Delivered = 3
        }
    }
}

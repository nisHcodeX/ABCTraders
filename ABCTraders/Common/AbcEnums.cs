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
        public enum UserStatus
        {
            Active = 0,
            Inactive = 1,
        }
        public enum FuelTypes
        {
            Petrol = 0,
            Diesel = 1,
            Electric = 2,
            Hybrid = 3,
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
            Delivered = 3,
            Cancelled = 4,
        }

        public enum StockStatus
        {
            Available = 0,
            Deleted = 1,
            OutOfStock = 2
        }

        public enum Transmission
        {
            Automatic = 0,
            Manual = 1,
            AutomatedManual = 2,
            CVT = 3
        }

        public enum CarColors
        {
            Red = 0,
            Blue = 1,
            White = 2,
            Black = 3,
            Silver = 4,
            Grey = 5,
            Green = 6,
            Yellow = 7,
            Orange = 8,
            Brown = 9,
            Other = 10,
        }

        public enum CarPartCategories
        {
            EngineComponents = 0,
            TransmissionAndDrivetrain = 1,
            SuspensionAndSteering = 2,
            BrakingSystem = 3,
            ElectricalAndLighting = 4,
            ExhaustSystem = 5,
            CoolingSystem = 6,
            FuelSystem = 7,
            InteriorComponents = 8,
            BodyAndExteriorParts = 9,
            Other = 10
        }
    }
}

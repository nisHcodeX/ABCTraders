using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ABCTraders.Common.AbcEnums;

namespace ABCTraders.Common
{
    internal class CommonLoader
    {
        public string GetCategoryName(int catId) {

            string categoryTest = Enum.GetName(typeof(CarPartCategories), catId);
            if (categoryTest != null)
            {
                return categoryTest;
            }
            else return "";
        }

        public string GetConditionName(int conId)
        {

            string categoryTest = Enum.GetName(typeof(CarCondition), conId);
            if (categoryTest != null)
            {
                return categoryTest;
            }
            else return "";
        }

        public string GetFuelType(int fuelId)
        {

            string categoryTest = Enum.GetName(typeof(FuelTypes), fuelId);
            if (categoryTest != null)
            {
                return categoryTest;
            }
            else return "";
        }

        public string GetStatus(int stautusId)
        {

            string categoryTest = Enum.GetName(typeof(CarStatus), stautusId);
            if (categoryTest != null)
            {
                return categoryTest;
            }
            else return "";
        }

    }
}

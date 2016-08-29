using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spark
{
    public static class Utilities
    {
        public static List<string> GetBlockedCustomers()
        {
            List<string> BlockedCustomers = new List<string>();
            BlockedCustomers.Add("6");
            BlockedCustomers.Add("9");
            BlockedCustomers.Add("11");
            BlockedCustomers.Remove("11");
            string SecondCustomer = BlockedCustomers[1];
            return BlockedCustomers; 
        }
    }
}
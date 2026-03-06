using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesExamples
{
    [System.AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    internal class VendorAttribute : System.Attribute
    {
        string vendorName;
        public double premiumAmount;

        public VendorAttribute(string vendorName)
        {
            this.vendorName = vendorName;
            this.premiumAmount = 99422;
        }

        public string GetVendorName()
        {
            return vendorName;
        }

    }
}

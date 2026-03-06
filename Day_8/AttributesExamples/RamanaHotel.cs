using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesExamples
{
    [Vendor(vendorName: "Zomoto"), Vendor("Ramana Tifins", premiumAmount = 85833.44)]
    internal class RamanaHotel
    {
        [Vendor(vendorName: "This is Constructor Data...Thank You")]
        public RamanaHotel() { }
    }
}

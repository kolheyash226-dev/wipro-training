using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributesExamples
{
    internal class Program
    {
        public static void PrintClassInfo(System.Type t)
        {
            MemberInfo info = t;
            object[] attrib = info.GetCustomAttributes(typeof(VendorAttribute), false);
            foreach (Object attribute in attrib)
            {
                VendorAttribute a = (VendorAttribute)attribute;
                Console.WriteLine("Company: {0}", a.GetVendorName());
            }


        }
        private static void PrintVendorInfo(System.Type t)
        {
            System.Console.WriteLine("Vendor information for {0}", t);
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.  

            foreach (System.Attribute attr in attrs)
            {
                if (attr is VendorAttribute)
                {
                    VendorAttribute a = (VendorAttribute)attr;
                    System.Console.WriteLine("   {0}, Premium Amount {1:f}", a.GetVendorName(), a.premiumAmount);
                }
            }
        }

        static void Main(string[] args)
        {
            PrintVendorInfo(typeof(Swiggy));
            PrintVendorInfo(typeof(RamanaHotel));

        }
    }
}

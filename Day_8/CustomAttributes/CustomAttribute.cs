using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class
        | AttributeTargets.Constructor,AllowMultiple =true)]
    internal class CustomAttribute : System.Attribute
    {
        public string InformationString { get; set; }
    }
}

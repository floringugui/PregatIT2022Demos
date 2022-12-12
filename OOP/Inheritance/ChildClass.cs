using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class ChildClass : BaseClass
    {
        public int DoSomethingElse()
        {
            var propValue = VariableProp;
            DoSomething();
            return 0;
        }
    }
}

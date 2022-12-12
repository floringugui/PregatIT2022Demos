using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class BaseClass
    {
        private int _variable;

        public BaseClass() { }

        public BaseClass(int variable)
        {
            _variable= variable;
        }

        protected int VariableProp { get; set; }

        public int DoSomething()
        {
            var i = _variable;
            // Another logic
            return MakeCalculation();
        }

        private static int MakeCalculation()
        {
            int i = 0;
            i++;
            return i;
        }

    }
}

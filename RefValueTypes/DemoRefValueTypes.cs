using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValueTypes
{
    public class DemoRefValueTypes
    {
        // Outer scope
        string _refStringModified = "100";
        RefTypeDemo _refTypeClassModified = new RefTypeDemo { Prop1 = 1000 };

        public void ExecuteDemo()
        {
            // Value type - "primitive" -> int, double, float, bool, array, struct, record // ValueType base class
            int valueType = 0;            

            // Reference types - string, class (own created ones as well), object
            string refString = "RefString";
            RefTypeDemo refTypeClass = new RefTypeDemo { Prop1 = 2 };

            Console.WriteLine($"IntTypeValue: {valueType}");
            Console.WriteLine($"StringTypeValue: {refString}");
            Console.WriteLine($"ClassTypeValue: {refTypeClass.Prop1}");


            DoSomething(valueType, refString, refTypeClass);


            Console.WriteLine($"IntTypeValue: {valueType}");
            Console.WriteLine($"StringTypeValue: {refString}");
            Console.WriteLine($"ClassTypeValue: {refTypeClass.Prop1}");

        }

        public int DoSomething(int valueType, string stringType, RefTypeDemo classType)
        {
            valueType = 10;
            stringType = "100";
            classType.Prop1 = 1000;

            return 0;
        }

        public class RefTypeDemo
        {
            public int Prop1 { get; set; }
        }
    }
}

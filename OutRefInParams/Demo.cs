using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutRefInParams
{
    public class Demo
    {
       

        public void ExecuteDemo()
        {
            // Value type - "primitive" -> int, double, float, bool, array, struct, record // ValueType base class
            int valueType = 0;



            // Reference types - string, class (own created ones as well), object
            string refString = "RefString";
            RefTypeDemo refTypeClass = new RefTypeDemo { Prop1 = 2 };

            //Console.WriteLine($"IntTypeValue: {valueType}");
            Console.WriteLine($"StringTypeValue: {refString}");
            Console.WriteLine($"ClassTypeValue: {refTypeClass.Prop1}");


            //DoSomethingWithOut(out valueType, out refString, out refTypeClass);
            //DoSomethingWithRef(ref valueType, ref refString, ref refTypeClass);
            //DoSomethingWithIn(in valueType, in refString, in refTypeClass);
            DoSomethingWithParams(valueType, refString, refTypeClass, 1, 2, 3, 4);


            Console.WriteLine($"IntTypeValue: {valueType}");
            Console.WriteLine($"StringTypeValue: {refString}");
            Console.WriteLine($"ClassTypeValue: {refTypeClass.Prop1}");

        }

        private int DoSomethingWithOut(out int valueType, out string stringType, out RefTypeDemo classType)
        {
            if(false)
            {
                valueType = 10;
            }
            else
            {
                valueType = 20;
            }
            
            stringType = "100";
            classType = new RefTypeDemo { Prop1 = 1000 };

            return 0;
        }

        private int DoSomethingWithRef(ref int valueType, ref string stringType, ref RefTypeDemo classType)
        {
            if (false)
            {
                valueType = 10;
            }

            stringType = "100";
            classType = new RefTypeDemo { Prop1 = 1000 };

            return 0;
        }

        private int DoSomethingWithIn(in int valueType, in string stringType, in RefTypeDemo classType)
        {
            var locaVar = valueType;


            return 0;
        }

        private int DoSomethingWithParams(int valueType, string stringType, RefTypeDemo classType, params int[] values)
        {
            if (false)
            {
                valueType = 10;
            }

            stringType = "100";
            classType = new RefTypeDemo { Prop1 = 1000 };

            foreach(var value in values)
            {
                Console.WriteLine(value);
            }

            return 0;
        }

        protected class RefTypeDemo
        {
            public int Prop1 { get; set; }
        }
    }
}

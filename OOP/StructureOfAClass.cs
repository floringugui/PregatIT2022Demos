using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // internal - current assembly / dll / project
    // protected - same as private, but accessible for the classes that inherit the current class
    // public - everyone
    // private - none; except the current class tha defines them

    public class StructureOfAClass
    {
        // Fields
        private int _field1;
        private string _field2;


        // Constructors
        public StructureOfAClass() { }

        public StructureOfAClass(int field1, string field2) 
        {
            _field1= field1;
            _field2= field2;
        }


        // Properties
        public int Field1
        {
            get { return _field1; }
            set { _field1 = value; }
        }

         public string Field2 { get; set; }

        public AnotherClass Prop { get; set; }

        // Methods / Functions
        void DoSomething()
        {

        }


        // ?? Imbricated classes / structs
        public class AnotherClass
        {

        }
    }
}

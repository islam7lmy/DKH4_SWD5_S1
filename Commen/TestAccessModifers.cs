using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    public class TestAccessModifers
    {
        private int test { get; set; }

        private protected int test1 { get; set; }

        protected int test2 { get; set; }

        internal protected int test3 { get; set; }

        internal int test4 { get; set; }

        public int test5 { get; set; }


    }

    class TestAccessModifers2 : TestAccessModifers
    {
        public void Test()
        {
            //test = 1; // private => allow in current class only
            test1 = 20; // private protected => allow in current class and derived class in same assembly
            test2 = 10; // protected => allow in current class and derived class
            test3 = 30; // internal protected => allow in current class and derived
            test4 = 50; // internal =>allow in current class and derived
            test5 = 60; // public =>allow in current class and derived
        }
    }

    class TestAccessModifers3 : TestAccessModifers2
    {
        public void Test()
        {
            //test = 1; // private => allow in current class only
            test1 = 10; // private protected => allow in current class and derived class in same assembly
            test2 = 20; // protected => allow in current class and derived class
            test3 = 30; // internal protected => allow in current class and derived
            test4 = 50; // internal =>allow in current class and derived
            test5 = 60; // pulic =>allow in current class and derived

        }
    }
}

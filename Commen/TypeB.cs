using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    internal class TypeB
    {
        TypeA O1 = new TypeA();
        TypeC TypeC = new TypeC();
        public TypeB()
        {
            //O1.x = 10; //private not accessable
            O1.y = 20; //internal accessable in same assembly 
            O1.z = 30; //public accessable in all locations

            //TypeC.x = 10; //private not accessable
            TypeC.y = 20; //internal accessable in same assembly 
            TypeC.z = 30; //public accessable in all locations
        }
    }
}

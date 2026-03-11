using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    public struct TypeC
    {
        /// Allowed Access Modifiers Inside The Struct
        /// 1. private [default]
        /// 2. internal
        /// 3. public

        int x; //by default private
        internal int y; // assembly only
        public int z; // all
    }
}

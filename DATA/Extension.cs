using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLMAOxSTARTER.DATA
{
    public static class Extension
    {
        public static int FloorMult(this float val, int mult, int add = 1) => ((int)val + add) * mult;
    }
}

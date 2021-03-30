using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInterface
{
    public  interface IMemCalc : ICalc
    {
        bool MemState
        {
            get;
        }
    }
}

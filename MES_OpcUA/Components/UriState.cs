using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_OpcUA.Components
{
    public enum UriState
    {
        OK = 0,
        NotInitialized = 1,
        BadAddress = 2,
        NoConnection = 3
    }
}

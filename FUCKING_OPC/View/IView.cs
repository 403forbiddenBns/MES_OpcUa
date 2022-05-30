using MES_OpcUa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_OpcUa.View
{   
        interface IView
        {
            bool? Open(BrowserViewModel browserVM);
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx;
using Opc.Ua;
using Opc.UaFx.Client;
using Prism.Mvvm;

namespace MES_OpcUA.Model
{
    public class MainModel : BindableBase
    {
        OpcClient opcClient; 

        public MainModel(string uri)
        {
            opcClient = new OpcClient(uri);
        }
    }
}

using Opc.UaFx.Client;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MES_OpcUa.Model
{
    public class BrowserModel
    {
        private OpcClient _opcClient;

        public OpcClient OpcClient
        {
            get { return _opcClient; }
        }

        public BrowserModel(OpcClient client)
        {
            _opcClient = client;
        }
    }
}

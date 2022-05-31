using MES_OpcUa.Components;
using Opc.UaFx.Client;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MES_OpcUa.Model
{
    public class BrowserModel
    {
        //private OpcClient _opcClient;
        private OpcClient _client;

        public OpcClient Client { get { return _client; } set { _client = value; } }

        public BrowserModel(OpcClient client)
        {
            _client = client;
        }
    }
}

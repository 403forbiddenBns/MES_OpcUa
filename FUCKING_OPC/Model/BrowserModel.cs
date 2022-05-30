using MES_OpcUa.Components;
using Opc.UaFx.Client;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MES_OpcUa.Model
{
    public class BrowserModel
    {
        //private OpcClient _opcClient;
        ClientStore _clientStore;


        public BrowserModel(ClientStore clientStore)
        {
            _clientStore = clientStore;
            //_opcClient = client;
        }
    }
}

using MES_OpcUa.Components;
using Opc.UaFx;
using Opc.UaFx.Client;

namespace MES_OpcUa.Model
{
    public class MainModel
    {
        private BrowserModel _browserModel;
        private OpcClient _client;
        private ClientStore _clientStore;

        public BrowserModel BrowserModel
        {
            get { return _browserModel; }
        }

        public MainModel(string address)
        { //TODO: FIX!
            _client = new OpcClient(address);


            _browserModel = new BrowserModel(_client);
            _browserModel.OpcClient.Connect();
        }
    }
}

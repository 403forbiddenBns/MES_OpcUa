using Opc.UaFx;
using Opc.UaFx.Client;

namespace MES_OpcUa.Model
{
    public class MainModel
    {
        private BrowserModel _browserModel;
        private OpcClient _client;

        public BrowserModel BrowserModel
        {
            get { return _browserModel; }
        }

        public MainModel(string address)
        {
            _client = new OpcClient(address, new OpcSecurityPolicy(OpcSecurityMode.None));
            _browserModel = new BrowserModel(_client);
            _browserModel.OpcClient.Connect();
            //TODO: CHECK CONNECTION HERE


            //TODO: check initialization for security policy and handle try catch.
        }
    }
}

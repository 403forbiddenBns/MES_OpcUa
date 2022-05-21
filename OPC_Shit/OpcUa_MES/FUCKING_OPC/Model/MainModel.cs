using Opc.UaFx.Client;

namespace MES_OpcUa.Model
{
    public class MainModel
    {
        private OpcClient _opcClient;
        public OpcClient OpcClient
        {
            get { return _opcClient; }
        }

        public MainModel(string address, Opc.UaFx.OpcSecurityPolicy opcSecurityPolicy)
        {
            _opcClient = new OpcClient(address, opcSecurityPolicy);
            _opcClient.Connect();
            //TODO: check initialization for security policy and handle try catch.
        }

    }
}

using MES_OpcUa.Components;
using Opc.UaFx;
using Opc.UaFx.Client;

namespace MES_OpcUa.Model
{
    public class MainModel
    {
        private OpcClient _client;

        public OpcClient Client
        {
            get { return _client; }
        }

        public MainModel(OpcClient client)
        {
            _client = client;
        }
    }
}

using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_OpcUa.Components
{
    public class ClientStore
    {
        //TODO: THIS IS PERFECT PLACE FOR CHECKING FOR ANY SHIT THAT COULD HAPPEND WHILE INITIALIZATION
        public event Action<OpcClient> ClientCreated;

        public void CreateClient(OpcClient client)
        {
            ClientCreated?.Invoke(client);
        }
    }
}

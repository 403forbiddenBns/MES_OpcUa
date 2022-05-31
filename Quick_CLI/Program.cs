using Opc.UaFx;
using Opc.UaFx.Client;
using System;
using System.Collections;

namespace Quick_CLI
{
    class Program
    {
        static void Main()
        {
            var client = new OpcClient("opc.tcp://DESKTOP-4LC5DK7:53530", new OpcSecurityPolicy(OpcSecurityMode.None)); //opc.tcp://172.24.182.20:45500

            client.Connect();
            /////////////////

            var res = client.BrowseNode("i=84");

            var bar = Foo(res);

            Console.WriteLine(bar);

            //////////////////
            client.Disconnect();
        }

        static void Browse(OpcNodeInfo node, int level = 0)
        {
            string pattern = new string('.', level * 4);
            var value = node.Attribute(OpcAttribute.DisplayName).Value;

            if (level == 0)
                Console.WriteLine($"_{level}{pattern}{value}{node.NodeId}");

            level++;

            foreach (var childNode in node.Children())
                Browse(childNode, level);
        }

        static IEnumerable Foo(OpcNodeInfo node)
        {
            yield return node.Children();
        }


    }
}

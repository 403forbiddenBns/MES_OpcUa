﻿using Opc.UaFx;
using Opc.UaFx.Client;
using System;

namespace Quick_CLI
{
    class Program
    {
        static void Main()
        {
            var client = new OpcClient("opc.tcp://DESKTOP-4LC5DK7:53530", new OpcSecurityPolicy(OpcSecurityMode.None));

            client.Connect();
            /////////////////

            var res = client.BrowseNode("i=84").Children();

            foreach (var item in res)
            {
                Console.WriteLine(item.Name);
            }


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


    }
}

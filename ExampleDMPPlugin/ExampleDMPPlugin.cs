using System;
using DarkMultiPlayerServer;
using DarkMultiPlayerCommon;

namespace ExampleDMPPlugin
{
    [DMPPlugin]
    public class ExampleDMPPlugin
    {
        private int updateCallCount = 0;

        public ExampleDMPPlugin()
        {
            DarkLog.Debug("ExampleDMPPlugin instantated!");
        }

        public void Update()
        {
            updateCallCount++;
        }

        public void OnClientConnect(ClientObject client)
        {
            DarkLog.Debug("[ExamplePluginTest] somebody connected with the server");
        }

        public void OnClientAuthenticated(ClientObject client)
        {
            DarkLog.Debug("[ExamplePluginTest] " + client.playerName + " authenticated with the server");
        }

        public void OnClientDisconnect(ClientObject client)
        {
            DarkLog.Debug("[ExamplePluginTest] " + client.playerName + " disconnected from the server");
        }

        public void OnMessageReceived(ClientObject client, ClientMessage message)
        {
            DarkLog.Debug("[ExamplePluginTest] " + "Got a " + message.type.ToString() + " message from " + client.playerName);
        }
    }
}


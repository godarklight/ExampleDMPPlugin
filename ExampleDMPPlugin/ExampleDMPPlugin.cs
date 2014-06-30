using System;
using DarkMultiPlayerServer;
using DarkMultiPlayerCommon;
using ExamplePluginLogic;

namespace ExampleDMPPlugin
{
    [DMPPlugin]
    public class ExampleDMPPlugin
    {
        private int updateCallCount = 0;

        public ExampleDMPPlugin()
        {
            DarkLog.Debug("ExampleDMPPlugin instantated!");
            int numbera = 6;
            int numberb = 7;
            ExamplePluginLogicMain eplm = new ExamplePluginLogicMain();
            DarkLog.Debug("Doing something magic with the numbers " + numbera + " and " + numberb + ", the result was " + eplm.DoSomethingMagicWithTwoNumbers(numbera, numberb));

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


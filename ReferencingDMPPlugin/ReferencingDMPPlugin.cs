using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkMultiPlayerCommon;
using DarkMultiPlayerServer;
using PluginExtras;

namespace ReferencingDMPPlugin
{
    [DMPPlugin]
    public class ReferencingDMPPlugin
    {
        private int updateCallCount = 0;

        PluginLogic logic;

        public ReferencingDMPPlugin()
        {
            DarkLog.Debug("ReferencingDMPPlugin instantated!");
            logic = new PluginLogic();
            DarkLog.Debug("ReferencingDMPPlugin logic instantated!");
        }

        public void Update()
        {
            updateCallCount++;
        }

        public void OnClientConnect(ClientObject client)
        {
            DarkLog.Debug("[ReferencingDMPPlugin] somebody connected with the server");
        }

        public void OnClientAuthenticated(ClientObject client)
        {
            DarkLog.Debug("[ReferencingDMPPlugin] " + client.playerName + " authenticated with the server");
        }

        public void OnClientDisconnect(ClientObject client)
        {
            DarkLog.Debug("[ReferencingDMPPlugin] " + client.playerName + " disconnected from the server");
        }

        public void OnMessageReceived(ClientObject client, ClientMessage message)
        {
            DarkLog.Debug("[ReferencingDMPPlugin] " + "Got a " + message.type.ToString() + " message from " + client.playerName);
            int sum = logic.Add(1, 2);
            DarkLog.Debug("[ReferencingDMPPlugin] Furthermore, 1 + 2 = " + sum);
        }
    }
}

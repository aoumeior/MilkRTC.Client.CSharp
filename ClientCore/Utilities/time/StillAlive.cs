using Newtonsoft.Json.Linq;
using PeerConnectionClientCore.Utilities.ServiceDepend;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PeerConnectionClientCore.Utilities.time
{
    public class StillAlive
    {
        public AutoResetEvent autoEvent = new AutoResetEvent(false);
        public Timer stateTimer;
        public Socket socket;
        public StillAlive(Socket socket)
        {
            this.socket = socket;
        }

        public void timer()
        {
            this.stateTimer = new Timer(this.Run,
            this.autoEvent, 20000* 10000, 250);
        }
        public void Run(Object stateInfo)
        {
            AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;
            var msgData2 = new msgT();
            msgData2.msgType = "stillAlive";
            this.socket.Emit("easyrtcCmd", (msg) =>
            {
            }, JToken.FromObject(msgData2));
        }
    }
}

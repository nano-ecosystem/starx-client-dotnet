using System;
using System.Text;
using SimpleJson;
using System.Net;
using System.Net.Sockets;

namespace StarX
{
    public class HandShakeService
    {
        private Protocol protocol;
        private Action<byte[]> callback;

        public const string Version = "0.3.0";
        public const string Type = "unity-socket";


        public HandShakeService(Protocol protocol)
        {
            this.protocol = protocol;
        }

        public void request(Action<byte[]> callback)
        {
            protocol.send(PackageType.PKG_HANDSHAKE, new byte[0]);
            this.callback = callback;
        }

        internal void invokeCallback(byte[] data)
        {
            //Invoke the handshake callback
            if (callback != null) callback.Invoke(data);
        }

        public void ack()
        {
            protocol.send(PackageType.PKG_HANDSHAKE_ACK, new byte[0]);
        }
    }
}
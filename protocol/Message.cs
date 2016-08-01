using System;
using SimpleJson;

namespace StarX
{
    public class Message
    {
        public MessageType type;
        public string route;
        public uint id;
        public byte[] data;

        public Message(MessageType type, uint id, string route, byte[] data)
        {
            this.type = type;
            this.id = id;
            this.route = route;
            this.data = data;
        }
    }
}
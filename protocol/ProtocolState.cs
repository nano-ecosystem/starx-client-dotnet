using System;

namespace StarX
{

    public enum ProtocolState
    {
        start = 1,          // Just open, need to send handshaking
        handshaking = 2,    // On handshaking process
        working = 3,		// can receive and send data 
        closed = 4,		    // On read body
    }
}
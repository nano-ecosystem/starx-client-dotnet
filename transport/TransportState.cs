using System;

namespace StarX
{

    public enum TransportState
    {
        readHead = 1,		// On read head
        readBody = 2,		// On read body
        closed = 3			// connection closed, will ignore all the message and wait for clean up
    }
}
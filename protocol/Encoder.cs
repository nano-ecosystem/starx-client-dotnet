using System;
using System.Collections;
using System.Collections.Generic;

namespace StarX
{
    public class Encoder
    {

        //Encode the UInt32.
        public static byte[] encodeUInt32(string n)
        {
            return encodeUInt32(Convert.ToUInt32(n));
        }

        /// <summary>
        /// Encode the UInt32.
        /// </summary>
        /// <returns>
        /// byte[]
        /// </returns>
        /// <param name='n'>
        /// int
        /// </param>
        public static byte[] encodeUInt32(uint n)
        {
            List<byte> byteList = new List<byte>();
            do
            {
                uint tmp = n % 128;
                uint next = n >> 7;
                if (next != 0)
                {
                    tmp = tmp + 128;
                }
                byteList.Add(Convert.ToByte(tmp));
                n = next;
            } while (n != 0);

            return byteList.ToArray();
        }

        //Encode SInt32
        public static byte[] encodeSInt32(string n)
        {
            return encodeSInt32(Convert.ToInt32(n));
        }

        /// <summary>
        /// Encodes the SInt32.
        /// </summary>
        /// <returns>
        /// byte []
        /// </returns>
        /// <param name='n'>
        /// int
        /// </param>
        public static byte[] encodeSInt32(int n)
        {
            UInt32 num = (uint)(n < 0 ? (Math.Abs(n) * 2 - 1) : n * 2);
            return encodeUInt32(num);
        }

        //Get the byte length of message.
        public static int byteLength(string msg)
        {
            return System.Text.Encoding.UTF8.GetBytes(msg).Length;
        }


    }
}
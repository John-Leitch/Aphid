/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Text;

namespace VSCodeDebug
{

    //--------------------------------------------------------------------------------------

    internal class ByteBuffer
    {
        private byte[] _buffer;

        public ByteBuffer() => _buffer = new byte[0];

        public int Length => _buffer.Length;

        public string GetString(Encoding enc) => enc.GetString(_buffer);

        public void Append(byte[] b, int length)
        {
            var newBuffer = new byte[_buffer.Length + length];
            System.Buffer.BlockCopy(_buffer, 0, newBuffer, 0, _buffer.Length);
            System.Buffer.BlockCopy(b, 0, newBuffer, _buffer.Length, length);
            _buffer = newBuffer;
        }

        public byte[] RemoveFirst(int n)
        {
            var b = new byte[n];
            System.Buffer.BlockCopy(_buffer, 0, b, 0, n);
            var newBuffer = new byte[_buffer.Length - n];
            System.Buffer.BlockCopy(_buffer, n, newBuffer, 0, _buffer.Length - n);
            _buffer = newBuffer;
            return b;
        }
    }
}

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace VSCodeDebug
{
    public class ProtocolMessage
    {
        public int seq;
        public string type;

        public ProtocolMessage()
        {
        }

        public ProtocolMessage(string typ) => type = typ;

        public ProtocolMessage(string typ, int sq)
        {
            type = typ;
            seq = sq;
        }
    }
}

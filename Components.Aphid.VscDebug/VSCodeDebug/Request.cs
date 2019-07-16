/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace VSCodeDebug
{
    public class Request : ProtocolMessage
    {
        public string command;
        public dynamic arguments;

        public Request()
        {
        }

        public Request(string cmd, dynamic arg)
            : base("request")
        {
            command = cmd;
            arguments = arg;
        }

        public Request(int id, string cmd, dynamic arg)
            : base("request", id)
        {
            command = cmd;
            arguments = arg;
        }
    }
}

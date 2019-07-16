/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace VSCodeDebug
{
    public class Response : ProtocolMessage
    {
        public bool success;
        public string message;
        public int request_seq;
        public string command;
        public ResponseBody body;

        public Response()
        {
        }

        public Response(Request req)
            : base("response")
        {
            success = true;
            request_seq = req.seq;
            command = req.command;
        }

        public void SetBody(ResponseBody bdy)
        {
            success = true;
            body = bdy;
        }

        public void SetErrorBody(string msg, ResponseBody bdy = null)
        {
            success = false;
            message = msg;
            body = bdy;
        }
    }
}

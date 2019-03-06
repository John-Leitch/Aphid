/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace VSCodeDebug
{
    // ---- Types -------------------------------------------------------------------------

    public class Message
    {
        public int id { get; private set; }
        public string format { get; private set; }
        public dynamic variables { get; private set; }
        public dynamic showUser { get; private set; }
        public dynamic sendTelemetry { get; private set; }

        public Message(int id, string format, dynamic variables = null, bool user = true, bool telemetry = false)
        {
            this.id = id;
            this.format = format;
            this.variables = variables;
            this.showUser = user;
            this.sendTelemetry = telemetry;
        }
    }
}

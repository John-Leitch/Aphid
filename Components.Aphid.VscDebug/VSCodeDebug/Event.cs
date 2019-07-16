/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Newtonsoft.Json;

namespace VSCodeDebug
{
    public class Event : ProtocolMessage
    {
        [JsonProperty(PropertyName = "event")]
        public string eventType { get; private set; }

        public dynamic body { get; private set; }

        public Event(string type, dynamic bdy = null)
            : base("event")
        {
            eventType = type;
            body = bdy;
        }
    }
}

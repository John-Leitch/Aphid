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
    public class ThreadEvent : Event
    {
        public ThreadEvent(string reasn, int tid)
            : base("thread", new
            {
                reason = reasn,
                threadId = tid
            })
        { }
    }
}

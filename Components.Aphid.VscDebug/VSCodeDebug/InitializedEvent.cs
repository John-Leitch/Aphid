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
    // ---- Events -------------------------------------------------------------------------

    public class InitializedEvent : Event
    {
        public InitializedEvent()
            : base("initialized")
        { }
    }
}

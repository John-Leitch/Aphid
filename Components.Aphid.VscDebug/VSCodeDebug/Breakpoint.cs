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
    public class Breakpoint
    {
        public bool verified { get; private set; }
        public int line { get; private set; }

        public Breakpoint(bool verified, int line)
        {
            this.verified = verified;
            this.line = line;
        }
    }
}

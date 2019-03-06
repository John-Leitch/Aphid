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
    public class Scope
    {
        public string name { get; private set; }
        public int variablesReference { get; private set; }
        public bool expensive { get; private set; }

        public Scope(string name, int variablesReference, bool expensive = false)
        {
            this.name = name;
            this.variablesReference = variablesReference;
            this.expensive = expensive;
        }
    }
}

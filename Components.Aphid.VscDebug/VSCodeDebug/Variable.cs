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
    public class Variable
    {
        public string name { get; private set; }
        public string value { get; private set; }
        public string type { get; private set; }
        public int variablesReference { get; private set; }

        public Variable(string name, string value, string type, int variablesReference = 0)
        {
            this.name = name;
            this.value = value;
            this.type = type;
            this.variablesReference = variablesReference;
        }
    }
}

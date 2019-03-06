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
    public class Source
    {
        public string name { get; private set; }
        public string path { get; private set; }
        public int sourceReference { get; private set; }
        public string presentationHint { get; private set; }

        public Source(string name, string path, int sourceReference, string hint)
        {
            this.name = name;
            this.path = path;
            this.sourceReference = sourceReference;
            this.presentationHint = hint;
        }
    }
}

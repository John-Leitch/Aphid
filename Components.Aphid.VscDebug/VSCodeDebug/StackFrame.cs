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
    public class StackFrame
    {
        public int id { get; private set; }
        public Source source { get; private set; }
        public int line { get; private set; }
        public int column { get; private set; }
        public string name { get; private set; }
        public string presentationHint { get; private set; }

        public StackFrame(int id, string name, Source source, int line, int column, string hint)
        {
            this.id = id;
            this.name = name;
            this.source = source;

            // These should NEVER be negative
            this.line = Math.Max(0, line);
            this.column = Math.Max(0, column);

            this.presentationHint = hint;
        }
    }
}

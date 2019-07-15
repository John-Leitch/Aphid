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
        public int column { get; private set; }

        public Breakpoint(bool verified, int line, int column)
        {
            this.verified = verified;
            this.line = line;
            this.column = column;
        }
    }

    //[Newtonsoft.Json.JsonObject(Name]
    //public class Breakpoint2
    //{
    //    public int id { get; private set; }
    //    public bool verified { get; private set; }
    //    public string message { get; private set; }
    //    public Source source { get; private set; }
    //    public int line { get; private set; }
    //    public int column { get; private set; }
    //    public int endLine { get; private set; }
    //    public int endColumn { get; private set; }

    //    public Breakpoint2(
    //        int id,
    //        bool verified,
    //        string message,
    //        Source source,
    //        int line,
    //        int column,
    //        int endLine,
    //        int endColumn)
    //    {
    //        this.id = id;
    //        this.verified = verified;
    //        this.message = message;
    //        this.source = source;
    //        this.line = line;
    //        this.column = column;
    //        this.endLine = endLine;
    //        this.endColumn = endColumn;
    //    }
    //}
}



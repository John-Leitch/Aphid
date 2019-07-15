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
    public class SourceBreakpoint
    {
        public int line { get; private set; }
        public int column { get; private set; }
        public string condition { get; private set; }
        public string hitCondition { get; private set; }
        public string logMessage { get; private set; }

        public SourceBreakpoint(
            int line,
            int column,
            string condition,
            string hitCondition,
            string logMessage)
        {
            this.line = line;
            this.column = column;
            this.condition = condition;
            this.hitCondition = hitCondition;
            this.logMessage = logMessage;
        }
    }
}

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
    public class StackTraceResponseBody : ResponseBody
    {
        public StackFrame[] stackFrames { get; private set; }
        public int totalFrames { get; private set; }

        public StackTraceResponseBody(List<StackFrame> frames, int total)
        {
            stackFrames = frames.ToArray<StackFrame>();
            totalFrames = total;
        }
    }
}

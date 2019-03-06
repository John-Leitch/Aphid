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
    public class EvaluateResponseBody : ResponseBody
    {
        public string result { get; private set; }
        public int variablesReference { get; private set; }

        public EvaluateResponseBody(string value, int reff = 0)
        {
            result = value;
            variablesReference = reff;
        }
    }
}

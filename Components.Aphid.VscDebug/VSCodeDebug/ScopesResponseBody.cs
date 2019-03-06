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
    public class ScopesResponseBody : ResponseBody
    {
        public Scope[] scopes { get; private set; }

        public ScopesResponseBody(List<Scope> scps) => scopes = scps.ToArray<Scope>();
    }
}

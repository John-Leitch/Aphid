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
    // ---- Response -------------------------------------------------------------------------

    public class Capabilities : ResponseBody
    {
        public bool supportsConfigurationDoneRequest;
        public bool supportsFunctionBreakpoints;
        public bool supportsConditionalBreakpoints;
        public bool supportsEvaluateForHovers;
        public bool supportsExceptionInfoRequest;
        public bool supportsSetVariable;
        public bool supportsSetExpression;
        public bool supportsModulesRequest;
        public bool supportsStepBack;
        public bool supportsTerminateRequest;
        public dynamic[] exceptionBreakpointFilters;
    }
}

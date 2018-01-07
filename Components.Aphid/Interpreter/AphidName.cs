using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public static class AphidName
    {
        public const string
            Return = "$r",
            Imports = "$imports",
            ImplicitArg = "$_",
            ImplicitArgs = "$args",
            FramesKey = "$frames",
            Block = "$block",
            Scope = "$scope",
            Parent = "$parent",
            Extension = "$isExt",
            Script = "$script",
            Code = "$code";
    }
}

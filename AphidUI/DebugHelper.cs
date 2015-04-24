using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AphidUI
{
    public static class DebugHelper
    {
        [Conditional("DEBUG")]
        public static void Trace(
            string message = null, 
            [CallerFilePathAttribute] string filePath = null,
            [CallerMemberName] string memberName = null,
            [CallerLineNumber] int lineNumber = 0)
        {
            if (message == null)
            {
                var m = string.Format(
                    "[{0}] {1}() in {2} line {3}",
                    DateTime.Now.ToString("hh:mm:ss"),
                    memberName,
                    Path.GetFileName(filePath),
                    lineNumber);

                System.Diagnostics.Trace.WriteLine(m);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}

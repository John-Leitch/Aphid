using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.External;
using Components.External.ConsolePlus;

namespace Components.Aphid.UI.Formatters
{
    public static class FrameFormatter
    {
        public static string FormatFrame(int frameNum, in AphidFrame frame)
        {
            string rawFrameStr = null;
            AphidExpression frameExp = null;

            if (frame.Expression != null && frame.Expression.Filename == null)
            {
                var complete = AphidParent.FirstComplete(frame.Expression) ??
                    AphidParent.FirstNearComplete(frame.Expression);

                if (complete != null)
                {
                    frameExp = complete;
                    //rawFrameStr = complete.ToString();
                }
            }
            else
            {
                frameExp = frame.Expression;
            }

            if (rawFrameStr == null)
            {
                rawFrameStr = frame.ToString(true, useFullNames: false);
            }

            var frameStr = new StringBuilder(
                !"\r\n".Any(rawFrameStr.Contains) ?
                    rawFrameStr :
                    rawFrameStr
                        .NormalizeLines()
                        .SplitLines()
                        .Select(x => x.Trim())
                        .Join(" "));

            var truncated = false;
            int maxWidth;

            try
            {
                maxWidth = Console.WindowWidth - 12;
            }
            catch
            {
                // Todo: Move constant into config.
                maxWidth = 80;
            }

            var trim = frameStr.Length - maxWidth;

            if (trim > 0)
            {
                frameStr.Remove(maxWidth, trim);
                truncated = true;
            }

            var trimmed = frameStr.ToString().TrimEnd();
            frameStr.Clear();
            frameStr.Insert(0, SyntaxHighlightingFormatter.Format(trimmed));

            if (truncated)
            {
                frameStr.Append(" ~White~...~R~");
            }

            frameStr.Insert(0, LineNumberFormatter.Format(frameNum));

            var formattedPosition = SourcePositionFormatter.Format(frameExp);

            if (formattedPosition != null)
            {
                frameStr.Append(formattedPosition);
            }

            return frameStr.ToString();
        }
    }
}

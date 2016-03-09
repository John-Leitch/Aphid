using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.ConsolePlus
{
    public class CliProgressBar
    {
        private int _lastBarLength = -1;

        public double Minimum { get; set; }

        public double Maximum { get; set; }

        public double Value { get; set; }

        public CliProgressBar(double minimum, double maximum, double value)
        {
            Minimum = minimum;
            Maximum = maximum;
            Value = value;
        }

        public CliProgressBar(double maximum)
            : this (0, maximum, 0)
        {

        }

        public void Write()
        {
            lock (this)
            {
                if (!Environment.UserInteractive)
                {
                    return;
                }

                var consoleWidth = Console.BufferWidth - 2;
                var length = Maximum - Minimum;
                var segmentLength = ((double)consoleWidth / length);
                var barLength = (int)Math.Ceiling(Value * segmentLength);

                if (barLength > consoleWidth)
                {
                    barLength = consoleWidth;
                }

                if (_lastBarLength == barLength)
                {
                    return;
                }

                _lastBarLength = barLength;
                var fillerLength = consoleWidth - barLength;

                if (Maximum == 0)
                {
                    barLength = consoleWidth;
                    fillerLength = 0;
                }

                Cli.Write(
                    "\r ~Cyan~{0}~R~~Gray~{1}~R~",
                    new string('█', barLength),
                    new string('█', fillerLength));
            }
        }

        public void IncrementAndWrite()
        {
            lock (this)
            {
                Value++;
                Write();
            }
        }
    }
}

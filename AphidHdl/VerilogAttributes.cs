using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidHdl
{
    public class VerilogAttributes
    {
        public bool IsInput { get; }

        public bool IsOutput { get { return !IsInput; } }

        public bool IsWire { get; }

        public bool IsReg { get { return !IsWire; } }

        public bool IsSizeParam { get; }

        public int Size { get; }

        public string SizeParam { get; }

        public VerilogAttributes(bool isInput, bool isWire, bool isSizeParam, int size, string sizeParam)
        {
            IsInput = isInput;
            IsWire = isWire;
            IsSizeParam = isSizeParam;
            Size = size;
            SizeParam = sizeParam;
        }
    }
}

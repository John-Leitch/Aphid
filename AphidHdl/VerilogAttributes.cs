using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidHdl
{
    public class VerilogAttributes
    {
        public bool IsInput { get; private set; }

        public bool IsOutput { get { return !IsInput; } }

        public bool IsWire { get; private set; }

        public bool IsReg { get { return !IsWire; } }

        public bool IsSizeParam { get; private set; }

        public int Size { get; private set; }

        public string SizeParam { get; private set; }

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

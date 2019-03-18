using System;
using System.Xml.Serialization;
using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    [StructLayout(LayoutKind.Sequential), Serializable]
    public struct EXCEPTION_RECORD
    {
        public uint ExceptionCode;
        
        public uint ExceptionFlags;
        
        // Changed to uint for serialization, fix for 64
        [NonSerialized, XmlIgnore]
        public uint ExceptionRecord;
        
        [NonSerialized, XmlIgnore]
        public uint ExceptionAddress;
        
        public uint NumberParameters;
        
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.U4)]
        public uint[] ExceptionInformation;
    }
}

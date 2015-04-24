using System.CodeDom;

namespace AphidCodeGenerator
{
    public interface IAphidCodeObject
    {
        string CodeFile { get; }

        CodeObject CreateCodeObject();
    }
}

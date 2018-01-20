using System.CodeDom;

namespace Components.Aphid.Compiler
{
    public interface IAphidCodeObject
    {
        string CodeFile { get; }

        CodeObject CreateCodeObject();
    }
}

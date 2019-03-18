using Components.Aphid.TypeSystem;

namespace Components.Aphid.Interpreter
{
    public class AphidExecutionContext
    {
        public bool IsModified { get; set; }

        public bool IsHandled { get; set; }

        public AphidObject Result { get; set; }

        public AphidExecutionContext()
        {
        }

        public AphidExecutionContext(bool isModified, bool isHandled)
            : this()
        {
            IsModified = true;
            IsHandled = true;
        }
    }
}

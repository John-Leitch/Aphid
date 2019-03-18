namespace Components.Aphid.Interpreter
{
    public abstract class AphidRuntimeComponent
    {
        public AphidInterpreter Interpreter { get; }

        protected AphidRuntimeComponent(AphidInterpreter interpreter) => Interpreter = interpreter;
    }
}

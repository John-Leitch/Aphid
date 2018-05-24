namespace Components.Aphid.VSPackage {
    
    
    public partial class AphidBuildInterop {
        
        private static CompileDelegate _Compile;
        
        public static CompileDelegate Compile {
            get {
                return AphidBuildInterop._Compile;
            }
            set {
                AphidBuildInterop._Compile = value;
            }
        }
        
        public delegate string CompileDelegate(string path, string input, string @namespace);
    }
}

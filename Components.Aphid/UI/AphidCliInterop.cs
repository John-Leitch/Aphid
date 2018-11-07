using global::Components.Aphid.Parser;
using global::Components.Aphid.Interpreter;

namespace Components.Aphid.UI {
    
    
    public partial class AphidCli {
        
        private static UnwrapDelegate _Unwrap;
        
        public static UnwrapDelegate Unwrap {
            get {
                if ((AphidCli._Unwrap == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_98985a32c2f876ecca5fb39f8ab84aea());
                }
                return AphidCli._Unwrap;
            }
            set {
                AphidCli._Unwrap = value;
            }
        }
        
        public delegate System.Type UnwrapDelegate(object obj);
    }
}

namespace Components.Aphid.UI {
    
    
    public partial class AphidCli {
        
        private static GetUnwrappedTypeDelegate _GetUnwrappedType;
        
        public static GetUnwrappedTypeDelegate GetUnwrappedType {
            get {
                if ((AphidCli._GetUnwrappedType == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_98985a32c2f876ecca5fb39f8ab84aea());
                }
                return AphidCli._GetUnwrappedType;
            }
            set {
                AphidCli._GetUnwrappedType = value;
            }
        }
        
        public delegate System.Type GetUnwrappedTypeDelegate(object obj);
    }
}

namespace Components.Aphid.UI {
    
    
    public partial class AphidCli {
        
        private static GetAphidObjectTypeNameDelegate _GetAphidObjectTypeName;
        
        public static GetAphidObjectTypeNameDelegate GetAphidObjectTypeName {
            get {
                if ((AphidCli._GetAphidObjectTypeName == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_98985a32c2f876ecca5fb39f8ab84aea());
                }
                return AphidCli._GetAphidObjectTypeName;
            }
            set {
                AphidCli._GetAphidObjectTypeName = value;
            }
        }
        
        public delegate string GetAphidObjectTypeNameDelegate(object obj);
    }
}

namespace Components.Aphid.UI {
    
    
    public partial class AphidCli {
        
        private static GetAphidTypeNameDelegate _GetAphidTypeName;
        
        public static GetAphidTypeNameDelegate GetAphidTypeName {
            get {
                if ((AphidCli._GetAphidTypeName == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_98985a32c2f876ecca5fb39f8ab84aea());
                }
                return AphidCli._GetAphidTypeName;
            }
            set {
                AphidCli._GetAphidTypeName = value;
            }
        }
        
        public delegate string GetAphidTypeNameDelegate(System.Type type);
    }
}

namespace Components.Aphid.UI {
    
    
    public partial class AphidCli {
        
        private static GetTypeNameDelegate _GetTypeName;
        
        public static GetTypeNameDelegate GetTypeName {
            get {
                if ((AphidCli._GetTypeName == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_98985a32c2f876ecca5fb39f8ab84aea());
                }
                return AphidCli._GetTypeName;
            }
            set {
                AphidCli._GetTypeName = value;
            }
        }
        
        public delegate string GetTypeNameDelegate(System.Type type);
    }
}

namespace Components.Aphid.UI {
    
    
    public partial class AphidCli {
        
        private static GetTypeFullNameDelegate _GetTypeFullName;
        
        public static GetTypeFullNameDelegate GetTypeFullName {
            get {
                if ((AphidCli._GetTypeFullName == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_98985a32c2f876ecca5fb39f8ab84aea());
                }
                return AphidCli._GetTypeFullName;
            }
            set {
                AphidCli._GetTypeFullName = value;
            }
        }
        
        public delegate string GetTypeFullNameDelegate(System.Type type);
    }
}

namespace Components.Aphid.UI {
    
    
    public partial class AphidCli {
        
        private static GetObjectTypeNameDelegate _GetObjectTypeName;
        
        public static GetObjectTypeNameDelegate GetObjectTypeName {
            get {
                if ((AphidCli._GetObjectTypeName == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_98985a32c2f876ecca5fb39f8ab84aea());
                }
                return AphidCli._GetObjectTypeName;
            }
            set {
                AphidCli._GetObjectTypeName = value;
            }
        }
        
        public delegate string GetObjectTypeNameDelegate(object obj);
    }
}

namespace Components.Aphid.UI {
    
    
    public partial class AphidCli {
        
        private static GetObjectTypeFullNameDelegate _GetObjectTypeFullName;
        
        public static GetObjectTypeFullNameDelegate GetObjectTypeFullName {
            get {
                if ((AphidCli._GetObjectTypeFullName == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_98985a32c2f876ecca5fb39f8ab84aea());
                }
                return AphidCli._GetObjectTypeFullName;
            }
            set {
                AphidCli._GetObjectTypeFullName = value;
            }
        }
        
        public delegate string GetObjectTypeFullNameDelegate(object obj);
    }
}

namespace Components.Aphid.UI
{
    using global::Components.Aphid.Lexer;
    using global::Components.Aphid.Parser;
    using System.Collections.Generic;
    
    public static partial class AphidCompilerResources
    {
        public static List<AphidExpression> ByteCode_98985a32c2f876ecca5fb39f8ab84aea()
        {
            return             new List<AphidExpression>
            {
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
                    new BinaryOperatorExpression(
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "Components",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "Aphid",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "UI",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
                    new BinaryOperatorExpression(
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "Components",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "Aphid",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "TypeSystem",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
                    new IdentifierExpression(
                        "System",
                        new List<IdentifierExpression>
                        {
                        }
                    ),
                    false
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
                    new BinaryOperatorExpression(
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "System",
                                new List<IdentifierExpression>
                                {
                                }
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "Collections",
                                new List<IdentifierExpression>
                                {
                                }
                            )
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Generic",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "System",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Linq",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "System",
                            new List<IdentifierExpression>
                            {
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Text",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    false
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Core/Operators'"
                    )
                ),
                new LoadScriptExpression(
                    new StringExpression(
                        "'Meta/Reflection'"
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "AphidCli",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "Type",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "Unwrap",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "obj",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Object",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new ThisExpression(
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new DynamicMemberExpression(
                                                    new StringExpression(
                                                        "'$aphid'"
                                                    )
                                                )
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "ValueHelper",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Unwrap",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "obj",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                    }
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "AphidCli",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "Type",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "GetUnwrappedType",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "obj",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Object",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new TernaryOperatorExpression(
                                    AphidTokenType.ConditionalOperator,
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "val",
                                                new List<IdentifierExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "var",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new ThisExpression(
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new DynamicMemberExpression(
                                                                new StringExpression(
                                                                    "'$aphid'"
                                                                )
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "ValueHelper",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Unwrap",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "obj",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                }
                                            )
                                        ),
                                        AphidTokenType.NotEqualOperator,
                                        new NullExpression(
                                        )
                                    ),
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "val",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "GetType",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new List<AphidExpression>
                                        {
                                        }
                                    ),
                                    new NullExpression(
                                    )
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "AphidCli",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "string",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "GetAphidObjectTypeName",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "obj",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Object",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new TernaryOperatorExpression(
                                    AphidTokenType.ConditionalOperator,
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "obj",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.EqualityOperator,
                                            new NullExpression(
                                            )
                                        ),
                                        AphidTokenType.OrOperator,
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "uw",
                                                    new List<IdentifierExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "var",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                ),
                                                AphidTokenType.AssignmentOperator,
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new BinaryOperatorExpression(
                                                                new ThisExpression(
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new DynamicMemberExpression(
                                                                    new StringExpression(
                                                                        "'$aphid'"
                                                                    )
                                                                )
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "ValueHelper",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Unwrap",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "obj",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                )
                                            ),
                                            AphidTokenType.EqualityOperator,
                                            new NullExpression(
                                            )
                                        )
                                    ),
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "AphidType",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Null",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new TernaryOperatorExpression(
                                        AphidTokenType.ConditionalOperator,
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "t",
                                                    new List<IdentifierExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "var",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                    }
                                                ),
                                                AphidTokenType.AssignmentOperator,
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "uw",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "GetType",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            AphidTokenType.EqualityOperator,
                                            new ArrayAccessExpression(
                                                new IdentifierExpression(
                                                    "List",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "AphidObject",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                }
                                            )
                                        ),
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "AphidType",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "List",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new TernaryOperatorExpression(
                                            AphidTokenType.ConditionalOperator,
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "alias",
                                                                new List<IdentifierExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "var",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            ),
                                                            AphidTokenType.AssignmentOperator,
                                                            new CallExpression(
                                                                new BinaryOperatorExpression(
                                                                    new IdentifierExpression(
                                                                        "AphidAlias",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                    AphidTokenType.MemberOperator,
                                                                    new IdentifierExpression(
                                                                        "Resolve",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    )
                                                                ),
                                                                new List<AphidExpression>
                                                                {
                                                                    new IdentifierExpression(
                                                                        "t",
                                                                        new List<IdentifierExpression>
                                                                        {
                                                                        }
                                                                    ),
                                                                }
                                                            )
                                                        ),
                                                        AphidTokenType.NotEqualOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "AphidType",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "Unknown",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    ),
                                                    AphidTokenType.AndOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "alias",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.NotEqualOperator,
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "AphidType",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "List",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        )
                                                    )
                                                ),
                                                AphidTokenType.AndOperator,
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "alias",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.NotEqualOperator,
                                                    new NullExpression(
                                                    )
                                                )
                                            ),
                                            new IdentifierExpression(
                                                "alias",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new CallExpression(
                                                        new IdentifierExpression(
                                                            "typeToString",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                            new IdentifierExpression(
                                                                "t",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            new BooleanExpression(
                                                                false
                                                            ),
                                                        }
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "ToString",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    )
                                                ),
                                                new List<AphidExpression>
                                                {
                                                }
                                            )
                                        )
                                    )
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "AphidCli",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "string",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "GetAphidTypeName",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "type",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Type",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new TernaryOperatorExpression(
                                    AphidTokenType.ConditionalOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "type",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.EqualityOperator,
                                        new ArrayAccessExpression(
                                            new IdentifierExpression(
                                                "List",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "AphidObject",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                            }
                                        )
                                    ),
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "AphidType",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "List",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new TernaryOperatorExpression(
                                        AphidTokenType.ConditionalOperator,
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "alias",
                                                            new List<IdentifierExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "var",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        ),
                                                        AphidTokenType.AssignmentOperator,
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "AphidAlias",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "Resolve",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new IdentifierExpression(
                                                                    "type",
                                                                    new List<IdentifierExpression>
                                                                    {
                                                                    }
                                                                ),
                                                            }
                                                        )
                                                    ),
                                                    AphidTokenType.NotEqualOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "AphidType",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Unknown",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                ),
                                                AphidTokenType.AndOperator,
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "alias",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    AphidTokenType.NotEqualOperator,
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "AphidType",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "List",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        )
                                                    )
                                                )
                                            ),
                                            AphidTokenType.AndOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "alias",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                AphidTokenType.NotEqualOperator,
                                                new NullExpression(
                                                )
                                            )
                                        ),
                                        new IdentifierExpression(
                                            "alias",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new CallExpression(
                                                    new IdentifierExpression(
                                                        "typeToString",
                                                        new List<IdentifierExpression>
                                                        {
                                                        }
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "type",
                                                            new List<IdentifierExpression>
                                                            {
                                                            }
                                                        ),
                                                        new BooleanExpression(
                                                            false
                                                        ),
                                                    }
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "ToString",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                )
                                            ),
                                            new List<AphidExpression>
                                            {
                                            }
                                        )
                                    )
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "AphidCli",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "string",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "GetTypeName",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "type",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Type",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "typeToString",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "type",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new BooleanExpression(
                                                    false
                                                ),
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "ToString",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                    }
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "AphidCli",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "string",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "GetTypeFullName",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "type",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Type",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "typeToString",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "type",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new BooleanExpression(
                                                    true
                                                ),
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "ToString",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                    }
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "AphidCli",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "string",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "GetObjectTypeName",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "obj",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Object",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new TernaryOperatorExpression(
                                    AphidTokenType.ConditionalOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "obj",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.NotEqualOperator,
                                        new NullExpression(
                                        )
                                    ),
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new CallExpression(
                                                new IdentifierExpression(
                                                    "typeToString",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "obj",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "GetType",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                        }
                                                    ),
                                                    new BooleanExpression(
                                                        false
                                                    ),
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "ToString",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new List<AphidExpression>
                                        {
                                        }
                                    ),
                                    new NullExpression(
                                    )
                                ),
                                false
                            ),
                        }
                    )
                ),
                new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "AphidCli",
                            new List<IdentifierExpression>
                            {
                                new IdentifierExpression(
                                    "export",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                                new IdentifierExpression(
                                    "string",
                                    new List<IdentifierExpression>
                                    {
                                    }
                                ),
                            }
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "GetObjectTypeFullName",
                            new List<IdentifierExpression>
                            {
                            }
                        )
                    ),
                    AphidTokenType.AssignmentOperator,
                    new FunctionExpression(
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "obj",
                                new List<IdentifierExpression>
                                {
                                    new IdentifierExpression(
                                        "Object",
                                        new List<IdentifierExpression>
                                        {
                                        }
                                    ),
                                }
                            ),
                        },
                        new List<AphidExpression>
                        {
                            new UnaryOperatorExpression(
                                AphidTokenType.retKeyword,
                                new TernaryOperatorExpression(
                                    AphidTokenType.ConditionalOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "obj",
                                            new List<IdentifierExpression>
                                            {
                                            }
                                        ),
                                        AphidTokenType.NotEqualOperator,
                                        new NullExpression(
                                        )
                                    ),
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new CallExpression(
                                                new IdentifierExpression(
                                                    "typeToString",
                                                    new List<IdentifierExpression>
                                                    {
                                                    }
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new CallExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "obj",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "GetType",
                                                                new List<IdentifierExpression>
                                                                {
                                                                }
                                                            )
                                                        ),
                                                        new List<AphidExpression>
                                                        {
                                                        }
                                                    ),
                                                    new BooleanExpression(
                                                        true
                                                    ),
                                                }
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "ToString",
                                                new List<IdentifierExpression>
                                                {
                                                }
                                            )
                                        ),
                                        new List<AphidExpression>
                                        {
                                        }
                                    ),
                                    new NullExpression(
                                    )
                                ),
                                false
                            ),
                        }
                    )
                ),
            }
;
        }
    }
}



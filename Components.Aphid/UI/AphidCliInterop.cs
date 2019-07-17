using global::Components.Aphid.Parser;
using global::Components.Aphid.Interpreter;

namespace Components.Aphid.UI {
    
    
    public partial class AphidCli {
        
        private static UnwrapDelegate _Unwrap;
        
        public static UnwrapDelegate Unwrap {
            get {
                if ((AphidCli._Unwrap == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_687d1ee39feed9b722e1ed8efbba01fc());
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
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_687d1ee39feed9b722e1ed8efbba01fc());
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
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_687d1ee39feed9b722e1ed8efbba01fc());
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
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_687d1ee39feed9b722e1ed8efbba01fc());
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
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_687d1ee39feed9b722e1ed8efbba01fc());
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
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_687d1ee39feed9b722e1ed8efbba01fc());
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
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_687d1ee39feed9b722e1ed8efbba01fc());
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
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_687d1ee39feed9b722e1ed8efbba01fc());
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
                /* Test */
                using global::Components.Aphid.Lexer;
                using global::Components.Aphid.Parser;
                using System;
                using System.Collections.Generic;
            
                public static partial class AphidCompilerResources
                {
                    
                    /*fmt*/

                    public static List<AphidExpression> ByteCode_687d1ee39feed9b722e1ed8efbba01fc() =>
                        ByteCode_687d1ee39feed9b722e1ed8efbba01fcLazy.Value;

                    private static readonly List<AphidExpression> _empty = new List<AphidExpression>();                    

                    private static System.Lazy<List<AphidExpression>> ByteCode_687d1ee39feed9b722e1ed8efbba01fcLazy =>
                        new System.Lazy<List<AphidExpression>>(() =>
                            new List<AphidExpression>
{
    new UnaryOperatorExpression(
        AphidTokenType.usingKeyword,
        new BinaryOperatorExpression(
            new BinaryOperatorExpression(
                new IdentifierExpression(
                    "Components",
                    _IdentifierExpressions
                ),
                AphidTokenType.MemberOperator,
                new IdentifierExpression(
                    "Aphid",
                    _IdentifierExpressions
                )
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "UI",
                _IdentifierExpressions
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
                    _IdentifierExpressions
                ),
                AphidTokenType.MemberOperator,
                new IdentifierExpression(
                    "Aphid",
                    _IdentifierExpressions
                )
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "TypeSystem",
                _IdentifierExpressions
            )
        ),
        false
    ),
    new UnaryOperatorExpression(
        AphidTokenType.usingKeyword,
        new IdentifierExpression(
            "System",
            _IdentifierExpressions
        ),
        false
    ),
    new UnaryOperatorExpression(
        AphidTokenType.usingKeyword,
        new BinaryOperatorExpression(
            new BinaryOperatorExpression(
                new IdentifierExpression(
                    "System",
                    _IdentifierExpressions
                ),
                AphidTokenType.MemberOperator,
                new IdentifierExpression(
                    "Collections",
                    _IdentifierExpressions
                )
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "Generic",
                _IdentifierExpressions
            )
        ),
        false
    ),
    new UnaryOperatorExpression(
        AphidTokenType.usingKeyword,
        new BinaryOperatorExpression(
            new IdentifierExpression(
                "System",
                _IdentifierExpressions
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "Linq",
                _IdentifierExpressions
            )
        ),
        false
    ),
    new UnaryOperatorExpression(
        AphidTokenType.usingKeyword,
        new BinaryOperatorExpression(
            new IdentifierExpression(
                "System",
                _IdentifierExpressions
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "Text",
                _IdentifierExpressions
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "Type",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "Unwrap",
                _IdentifierExpressions
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
                            _IdentifierExpressions
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
                                    _ThisExpression,
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
                                    _IdentifierExpressions
                                )
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "Unwrap",
                                _IdentifierExpressions
                            )
                        ),
                        new List<AphidExpression>
                        {
                            new IdentifierExpression(
                                "obj",
                                _IdentifierExpressions
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "Type",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "GetUnwrappedType",
                _IdentifierExpressions
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
                            _IdentifierExpressions
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
                                            _IdentifierExpressions
                                        ),
                                    }
                                ),
                                AphidTokenType.AssignmentOperator,
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                _ThisExpression,
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
                                                _IdentifierExpressions
                                            )
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "Unwrap",
                                            _IdentifierExpressions
                                        )
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "obj",
                                            _IdentifierExpressions
                                        ),
                                    }
                                )
                            ),
                            AphidTokenType.NotEqualOperator,
                            _NullExpression
                        ),
                        new CallExpression(
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "val",
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "GetType",
                                    _IdentifierExpressions
                                )
                            ),
                            _AphidExpressions
                        ),
                        _NullExpression
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "string",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "GetAphidObjectTypeName",
                _IdentifierExpressions
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
                            _IdentifierExpressions
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
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.EqualityOperator,
                                _NullExpression
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
                                                _IdentifierExpressions
                                            ),
                                        }
                                    ),
                                    AphidTokenType.AssignmentOperator,
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    _ThisExpression,
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
                                                    _IdentifierExpressions
                                                )
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "Unwrap",
                                                _IdentifierExpressions
                                            )
                                        ),
                                        new List<AphidExpression>
                                        {
                                            new IdentifierExpression(
                                                "obj",
                                                _IdentifierExpressions
                                            ),
                                        }
                                    )
                                ),
                                AphidTokenType.EqualityOperator,
                                _NullExpression
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "AphidType",
                                _IdentifierExpressions
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "Null",
                                _IdentifierExpressions
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
                                                _IdentifierExpressions
                                            ),
                                        }
                                    ),
                                    AphidTokenType.AssignmentOperator,
                                    new CallExpression(
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "uw",
                                                _IdentifierExpressions
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "GetType",
                                                _IdentifierExpressions
                                            )
                                        ),
                                        _AphidExpressions
                                    )
                                ),
                                AphidTokenType.EqualityOperator,
                                new ArrayAccessExpression(
                                    new IdentifierExpression(
                                        "List",
                                        _IdentifierExpressions
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new IdentifierExpression(
                                            "AphidObject",
                                            _IdentifierExpressions
                                        ),
                                    }
                                )
                            ),
                            new BinaryOperatorExpression(
                                new IdentifierExpression(
                                    "AphidType",
                                    _IdentifierExpressions
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "List",
                                    _IdentifierExpressions
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
                                                            _IdentifierExpressions
                                                        ),
                                                    }
                                                ),
                                                AphidTokenType.AssignmentOperator,
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "AphidAlias",
                                                            _IdentifierExpressions
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Resolve",
                                                            _IdentifierExpressions
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new IdentifierExpression(
                                                            "t",
                                                            _IdentifierExpressions
                                                        ),
                                                    }
                                                )
                                            ),
                                            AphidTokenType.NotEqualOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "AphidType",
                                                    _IdentifierExpressions
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "Unknown",
                                                    _IdentifierExpressions
                                                )
                                            )
                                        ),
                                        AphidTokenType.AndOperator,
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "alias",
                                                _IdentifierExpressions
                                            ),
                                            AphidTokenType.NotEqualOperator,
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "AphidType",
                                                    _IdentifierExpressions
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "List",
                                                    _IdentifierExpressions
                                                )
                                            )
                                        )
                                    ),
                                    AphidTokenType.AndOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "alias",
                                            _IdentifierExpressions
                                        ),
                                        AphidTokenType.NotEqualOperator,
                                        _NullExpression
                                    )
                                ),
                                new IdentifierExpression(
                                    "alias",
                                    _IdentifierExpressions
                                ),
                                new CallExpression(
                                    new BinaryOperatorExpression(
                                        new CallExpression(
                                            new IdentifierExpression(
                                                "typeToString",
                                                _IdentifierExpressions
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new IdentifierExpression(
                                                    "t",
                                                    _IdentifierExpressions
                                                ),
                                                new BooleanExpression(
                                                    false
                                                ),
                                            }
                                        ),
                                        AphidTokenType.MemberOperator,
                                        new IdentifierExpression(
                                            "ToString",
                                            _IdentifierExpressions
                                        )
                                    ),
                                    _AphidExpressions
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "string",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "GetAphidTypeName",
                _IdentifierExpressions
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
                            _IdentifierExpressions
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
                                _IdentifierExpressions
                            ),
                            AphidTokenType.EqualityOperator,
                            new ArrayAccessExpression(
                                new IdentifierExpression(
                                    "List",
                                    _IdentifierExpressions
                                ),
                                new List<AphidExpression>
                                {
                                    new IdentifierExpression(
                                        "AphidObject",
                                        _IdentifierExpressions
                                    ),
                                }
                            )
                        ),
                        new BinaryOperatorExpression(
                            new IdentifierExpression(
                                "AphidType",
                                _IdentifierExpressions
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "List",
                                _IdentifierExpressions
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
                                                        _IdentifierExpressions
                                                    ),
                                                }
                                            ),
                                            AphidTokenType.AssignmentOperator,
                                            new CallExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "AphidAlias",
                                                        _IdentifierExpressions
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "Resolve",
                                                        _IdentifierExpressions
                                                    )
                                                ),
                                                new List<AphidExpression>
                                                {
                                                    new IdentifierExpression(
                                                        "type",
                                                        _IdentifierExpressions
                                                    ),
                                                }
                                            )
                                        ),
                                        AphidTokenType.NotEqualOperator,
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "AphidType",
                                                _IdentifierExpressions
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "Unknown",
                                                _IdentifierExpressions
                                            )
                                        )
                                    ),
                                    AphidTokenType.AndOperator,
                                    new BinaryOperatorExpression(
                                        new IdentifierExpression(
                                            "alias",
                                            _IdentifierExpressions
                                        ),
                                        AphidTokenType.NotEqualOperator,
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "AphidType",
                                                _IdentifierExpressions
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "List",
                                                _IdentifierExpressions
                                            )
                                        )
                                    )
                                ),
                                AphidTokenType.AndOperator,
                                new BinaryOperatorExpression(
                                    new IdentifierExpression(
                                        "alias",
                                        _IdentifierExpressions
                                    ),
                                    AphidTokenType.NotEqualOperator,
                                    _NullExpression
                                )
                            ),
                            new IdentifierExpression(
                                "alias",
                                _IdentifierExpressions
                            ),
                            new CallExpression(
                                new BinaryOperatorExpression(
                                    new CallExpression(
                                        new IdentifierExpression(
                                            "typeToString",
                                            _IdentifierExpressions
                                        ),
                                        new List<AphidExpression>
                                        {
                                            new IdentifierExpression(
                                                "type",
                                                _IdentifierExpressions
                                            ),
                                            new BooleanExpression(
                                                false
                                            ),
                                        }
                                    ),
                                    AphidTokenType.MemberOperator,
                                    new IdentifierExpression(
                                        "ToString",
                                        _IdentifierExpressions
                                    )
                                ),
                                _AphidExpressions
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "string",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "GetTypeName",
                _IdentifierExpressions
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
                            _IdentifierExpressions
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
                                    _IdentifierExpressions
                                ),
                                new List<AphidExpression>
                                {
                                    new IdentifierExpression(
                                        "type",
                                        _IdentifierExpressions
                                    ),
                                    new BooleanExpression(
                                        false
                                    ),
                                }
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "ToString",
                                _IdentifierExpressions
                            )
                        ),
                        _AphidExpressions
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "string",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "GetTypeFullName",
                _IdentifierExpressions
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
                            _IdentifierExpressions
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
                                    _IdentifierExpressions
                                ),
                                new List<AphidExpression>
                                {
                                    new IdentifierExpression(
                                        "type",
                                        _IdentifierExpressions
                                    ),
                                    new BooleanExpression(
                                        true
                                    ),
                                }
                            ),
                            AphidTokenType.MemberOperator,
                            new IdentifierExpression(
                                "ToString",
                                _IdentifierExpressions
                            )
                        ),
                        _AphidExpressions
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "string",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "GetObjectTypeName",
                _IdentifierExpressions
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
                            _IdentifierExpressions
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
                                _IdentifierExpressions
                            ),
                            AphidTokenType.NotEqualOperator,
                            _NullExpression
                        ),
                        new CallExpression(
                            new BinaryOperatorExpression(
                                new CallExpression(
                                    new IdentifierExpression(
                                        "typeToString",
                                        _IdentifierExpressions
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "obj",
                                                    _IdentifierExpressions
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "GetType",
                                                    _IdentifierExpressions
                                                )
                                            ),
                                            _AphidExpressions
                                        ),
                                        new BooleanExpression(
                                            false
                                        ),
                                    }
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "ToString",
                                    _IdentifierExpressions
                                )
                            ),
                            _AphidExpressions
                        ),
                        _NullExpression
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
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "string",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "GetObjectTypeFullName",
                _IdentifierExpressions
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
                            _IdentifierExpressions
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
                                _IdentifierExpressions
                            ),
                            AphidTokenType.NotEqualOperator,
                            _NullExpression
                        ),
                        new CallExpression(
                            new BinaryOperatorExpression(
                                new CallExpression(
                                    new IdentifierExpression(
                                        "typeToString",
                                        _IdentifierExpressions
                                    ),
                                    new List<AphidExpression>
                                    {
                                        new CallExpression(
                                            new BinaryOperatorExpression(
                                                new IdentifierExpression(
                                                    "obj",
                                                    _IdentifierExpressions
                                                ),
                                                AphidTokenType.MemberOperator,
                                                new IdentifierExpression(
                                                    "GetType",
                                                    _IdentifierExpressions
                                                )
                                            ),
                                            _AphidExpressions
                                        ),
                                        new BooleanExpression(
                                            true
                                        ),
                                    }
                                ),
                                AphidTokenType.MemberOperator,
                                new IdentifierExpression(
                                    "ToString",
                                    _IdentifierExpressions
                                )
                            ),
                            _AphidExpressions
                        ),
                        _NullExpression
                    ),
                    false
                ),
            }
        )
    ),
}

                        );

                    
                        private static readonly List<IdentifierExpression> _IdentifierExpressions = new List<IdentifierExpression>();
                    
                        private static readonly List<AphidExpression> _AphidExpressions = new List<AphidExpression>();
                    

                    
                        private static readonly ThisExpression _ThisExpression = new ThisExpression();
                    
                        private static readonly NullExpression _NullExpression = new NullExpression();
                    
                    
                
                }
            }
            


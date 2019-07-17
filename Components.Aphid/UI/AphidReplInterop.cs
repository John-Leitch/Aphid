using global::Components.Aphid.Parser;
using global::Components.Aphid.Interpreter;

namespace Components.Aphid.UI {
    
    
    public partial class AphidRepl {
        
        private static InitDelegate _Init;
        
        public static InitDelegate Init {
            get {
                if ((AphidRepl._Init == null)) {
                    new AphidInterpreter().Interpret(AphidCompilerResources.ByteCode_18fa9ca5e36db7fbde73986a48275be1());
                }
                return AphidRepl._Init;
            }
            set {
                AphidRepl._Init = value;
            }
        }
        
        public delegate void InitDelegate();
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

                    public static List<AphidExpression> ByteCode_18fa9ca5e36db7fbde73986a48275be1() =>
                        ByteCode_18fa9ca5e36db7fbde73986a48275be1Lazy.Value;

                    //private static readonly List<AphidExpression> _empty = new List<AphidExpression>();                    

                    private static System.Lazy<List<AphidExpression>> ByteCode_18fa9ca5e36db7fbde73986a48275be1Lazy =>
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
    new BinaryOperatorExpression(
        new IdentifierExpression(
            "isInitialized",
            new List<IdentifierExpression>
            {
                new IdentifierExpression(
                    "var",
                    _IdentifierExpressions
                ),
            }
        ),
        AphidTokenType.AssignmentOperator,
        new BooleanExpression(
            false
        )
    ),
    new BinaryOperatorExpression(
        new BinaryOperatorExpression(
            new IdentifierExpression(
                "AphidRepl",
                new List<IdentifierExpression>
                {
                    new IdentifierExpression(
                        "export",
                        _IdentifierExpressions
                    ),
                    new IdentifierExpression(
                        "void",
                        _IdentifierExpressions
                    ),
                }
            ),
            AphidTokenType.MemberOperator,
            new IdentifierExpression(
                "Init",
                _IdentifierExpressions
            )
        ),
        AphidTokenType.AssignmentOperator,
        new FunctionExpression(
            _AphidExpressions,
            new List<AphidExpression>
            {
                new IfExpression(
                    new IdentifierExpression(
                        "isInitialized",
                        _IdentifierExpressions
                    ),
                    new List<AphidExpression>
                    {
                        new UnaryOperatorExpression(
                            AphidTokenType.retKeyword,
                            _NullExpression,
                            false
                        ),
                    },
                    null
                ),
                new UnaryOperatorExpression(
                    AphidTokenType.usingKeyword,
                    new IdentifierExpression(
                        "System",
                        _IdentifierExpressions
                    ),
                    false
                ),
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        "isInitialized",
                        _IdentifierExpressions
                    ),
                    AphidTokenType.AssignmentOperator,
                    new BooleanExpression(
                        true
                    )
                ),
                new CallExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression(
                            "Console",
                            _IdentifierExpressions
                        ),
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression(
                            "add_CancelKeyPress",
                            _IdentifierExpressions
                        )
                    ),
                    new List<AphidExpression>
                    {
                        new FunctionExpression(
                            new List<AphidExpression>
                            {
                                new IdentifierExpression(
                                    "o",
                                    _IdentifierExpressions
                                ),
                                new IdentifierExpression(
                                    "e",
                                    _IdentifierExpressions
                                ),
                            },
                            new List<AphidExpression>
                            {
                                new LockExpression(
                                    new List<AphidExpression>
                                    {
                                        new BinaryOperatorExpression(
                                            new IdentifierExpression(
                                                "AphidRepl",
                                                _IdentifierExpressions
                                            ),
                                            AphidTokenType.MemberOperator,
                                            new IdentifierExpression(
                                                "RunThreadSync",
                                                _IdentifierExpressions
                                            )
                                        ),
                                    },
                                    new List<AphidExpression>
                                    {
                                        new IfExpression(
                                            new BinaryOperatorExpression(
                                                new BinaryOperatorExpression(
                                                    new IdentifierExpression(
                                                        "AphidRepl",
                                                        _IdentifierExpressions
                                                    ),
                                                    AphidTokenType.MemberOperator,
                                                    new IdentifierExpression(
                                                        "RunThread",
                                                        _IdentifierExpressions
                                                    )
                                                ),
                                                AphidTokenType.NotEqualOperator,
                                                _NullExpression
                                            ),
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "AphidCli",
                                                            _IdentifierExpressions
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "IsAborting",
                                                            _IdentifierExpressions
                                                        )
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new BooleanExpression(
                                                        true
                                                    )
                                                ),
                                                new CallExpression(
                                                    new BinaryOperatorExpression(
                                                        new BinaryOperatorExpression(
                                                            new IdentifierExpression(
                                                                "AphidRepl",
                                                                _IdentifierExpressions
                                                            ),
                                                            AphidTokenType.MemberOperator,
                                                            new IdentifierExpression(
                                                                "RunThread",
                                                                _IdentifierExpressions
                                                            )
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Abort",
                                                            _IdentifierExpressions
                                                        )
                                                    ),
                                                    _AphidExpressions
                                                ),
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "e",
                                                            _IdentifierExpressions
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Cancel",
                                                            _IdentifierExpressions
                                                        )
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new BooleanExpression(
                                                        true
                                                    )
                                                ),
                                            },
                                            new List<AphidExpression>
                                            {
                                                new BinaryOperatorExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "e",
                                                            _IdentifierExpressions
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "Cancel",
                                                            _IdentifierExpressions
                                                        )
                                                    ),
                                                    AphidTokenType.AssignmentOperator,
                                                    new BooleanExpression(
                                                        false
                                                    )
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
                                                            "Diagnostics",
                                                            _IdentifierExpressions
                                                        )
                                                    ),
                                                    false
                                                ),
                                                new IfExpression(
                                                    new BinaryOperatorExpression(
                                                        new IdentifierExpression(
                                                            "Debugger",
                                                            _IdentifierExpressions
                                                        ),
                                                        AphidTokenType.MemberOperator,
                                                        new IdentifierExpression(
                                                            "IsAttached",
                                                            _IdentifierExpressions
                                                        )
                                                    ),
                                                    new List<AphidExpression>
                                                    {
                                                        new CallExpression(
                                                            new BinaryOperatorExpression(
                                                                new IdentifierExpression(
                                                                    "Environment",
                                                                    _IdentifierExpressions
                                                                ),
                                                                AphidTokenType.MemberOperator,
                                                                new IdentifierExpression(
                                                                    "Exit",
                                                                    _IdentifierExpressions
                                                                )
                                                            ),
                                                            new List<AphidExpression>
                                                            {
                                                                new NumberExpression(
                                                                    0
                                                                ),
                                                            }
                                                        ),
                                                    },
                                                    null
                                                ),
                                            }
                                        ),
                                    }
                                ),
                            }
                        ),
                    }
                ),
            }
        )
    ),
}

                        );

                    
                        //private static readonly List<IdentifierExpression> _IdentifierExpressions = new List<IdentifierExpression>();
                    
                        //private static readonly List<AphidExpression> _AphidExpressions = new List<AphidExpression>();
                    

                    
                        //private static readonly NullExpression _NullExpression = new NullExpression();
                    
                    
                
                }
            }
            


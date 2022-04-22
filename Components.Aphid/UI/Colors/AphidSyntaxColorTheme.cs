using Components.Aphid.Lexer;
using Components.External.ConsolePlus;
using static Components.Aphid.Lexer.AphidTokenType;
using T = Components.Aphid.Lexer.AphidTokenType;
using B = System.Byte;

namespace Components.Aphid.UI.Colors
{
    public abstract class AphidSyntaxColorTheme : IAphidTokenColorTheme
    {
        public abstract B[] Foreground { get; }

        public abstract B[] Background { get; }

        public abstract B[] StringLiteral { get; }

        public abstract B[] Number { get; }

        public abstract B[] Keyword { get; }

        public virtual B[] Attribute => Keyword;

        public abstract B[] Identifier { get; }

        public abstract B[] Operator { get; }

        public virtual B[] MemberOperator => Operator;

        public abstract B[] Bracket { get; }

        public virtual B[] Parenthesis => Bracket;

        public abstract B[] Comment { get; }

        public ColoredText GetColoredText(in AphidToken token) =>
            GetColoredText(token, None);

        public ColoredText GetColoredText(in AphidToken token, T nextType) =>
            new(GetColor(token.TokenType, nextType), token.Lexeme);

        public B[] GetColor(T type) =>
            GetColor(type, None);

        public B[] GetColor(T type, T nextType) =>
            type switch
            {
                T.String => StringLiteral,
                T.Number or HexNumber or BinaryNumber => Number,
                T.Identifier => nextType switch
                    {
                        T.Identifier or ImplicitArgumentOperator or
                            ImplicitArgumentsOperator or
                            PatternMatchingOperator or
                            BinaryNumber or
                            T.Number or
                            HexNumber => Attribute,
                        _ => Identifier,
                    },
                andKeyword or
                    breakKeyword or
                    catchKeyword or
                    continueKeyword or
                    defaultKeyword or
                    definedKeyword or
                    deleteKeyword or
                    doKeyword or
                    elseKeyword or
                    extendKeyword or
                    falseKeyword or
                    finallyKeyword or
                    forKeyword or
                    ifKeyword or
                    inKeyword or
                    loadKeyword or
                    lockKeyword or
                    newKeyword or
                    nullKeyword or
                    orKeyword or
                    retKeyword or
                    switchKeyword or
                    thisKeyword or
                    throwKeyword or
                    toKeyword or
                    trueKeyword or
                    tryKeyword or
                    usingKeyword or
                    whileKeyword or
                    ImplicitArgumentOperator or
                    ImplicitArgumentsOperator or
                    FunctionOperator or
                    InteropOperator or
                    LoadLibraryOperator or
                    LoadScriptOperator or
                    PatternMatchingOperator => Keyword,
                AdditionOperator or
                    AggregateOperator or
                    AndOperator or
                    AnyOperator or
                    AssignmentOperator or
                    BinaryAndEqualOperator or
                    BinaryAndOperator or
                    BinaryOrOperator or
                    ColonOperator or
                    ComplementOperator or
                    ConditionalOperator or
                    DecrementOperator or
                    DistinctOperator or
                    DivisionEqualOperator or
                    DivisionOperator or
                    EqualityOperator or
                    GreaterThanOperator or
                    GreaterThanOrEqualOperator or
                    IncrementOperator or
                    LessThanOperator or
                    LessThanOrEqualOperator or
                    MinusEqualOperator or
                    MinusOperator or
                    ModulusEqualOperator or
                    ModulusOperator or
                    MultiplicationEqualOperator or
                    MultiplicationOperator or
                    NotEqualOperator or
                    NotOperator or
                    OrEqualOperator or
                    OrOperator or
                    PipelineOperator or
                    PlusEqualOperator or
                    RangeOperator or
                    SelectManyOperator or
                    SelectOperator or
                    ShiftLeftEqualOperator or
                    ShiftRightEqualOperator or
                    WhereOperator or
                    XorEqualOperator or
                    XorOperator => Operator,
                LeftBrace or
                    RightBrace or
                    LeftBracket or
                    RightBracket => Bracket,
                T.MemberOperator => MemberOperator,
                RightParenthesis or
                    LeftParenthesis => Parenthesis,
                T.Comment => Comment,
                T.Text => Foreground,
                T.ShellText => Foreground,
                _ => null,
            };
    }
}

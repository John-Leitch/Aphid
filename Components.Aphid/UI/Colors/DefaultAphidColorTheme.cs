using Components.Aphid.Lexer;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Components.Aphid.Lexer.AphidTokenType;

namespace Components.Aphid.UI.Colors
{
    public abstract class AphidSyntaxColorTheme : IAphidTokenColorTheme
    {
        public abstract byte[] Foreground { get; }

        public abstract byte[] Background { get; }

        public abstract byte[] StringLiteral { get; }

        public abstract byte[] Number { get; }

        public abstract byte[] Keyword { get; }

        public virtual byte[] AttributeColor => Keyword;

        public abstract byte[] Identifier { get; }

        public abstract byte[] Operator { get; }

        public virtual byte[] MemberOperatorColor => Operator;

        public abstract byte[] Bracket { get; }

        public virtual byte[] ParenthesisColor => Bracket;

        public abstract byte[] Comment { get; }

        public ColoredText GetColoredText(in AphidToken token) =>
            GetColoredText(token, None);

        public ColoredText GetColoredText(in AphidToken token, AphidTokenType nextType) =>
            new(GetColor(token.TokenType, nextType), token.Lexeme);

        public byte[] GetColor(AphidTokenType type) =>
            GetColor(type, None);

        public byte[] GetColor(AphidTokenType type, AphidTokenType nextType) =>
            type switch
            {
                AphidTokenType.String => StringLiteral,
                AphidTokenType.Number or HexNumber or BinaryNumber => Number,
                AphidTokenType.Identifier => nextType switch
                    {
                        AphidTokenType.Identifier or ImplicitArgumentOperator or
                            ImplicitArgumentsOperator or
                            PatternMatchingOperator or
                            BinaryNumber or
                            AphidTokenType.Number or
                            HexNumber => AttributeColor,
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
                MemberOperator => MemberOperatorColor,
                RightParenthesis or
                    LeftParenthesis => ParenthesisColor,
                AphidTokenType.Comment => Comment,
                _ => Foreground,
            };
    }

    public class DefaultAphidColorTheme : AphidSyntaxColorTheme
    {
        public override byte[] Foreground => SystemColor.White;

        public override byte[] Background => SystemColor.Black;

        public override byte[] StringLiteral => SystemColor.Coral;

        public override byte[] Number => SystemColor.PaleGoldenrod;

        public override byte[] Keyword => SystemColor.DodgerBlue;

        public override byte[] Identifier => SystemColor.CadetBlue;

        public override byte[] Operator => SystemColor.Silver;

        public override byte[] Bracket => SystemColor.LightGray;

        public override byte[] Comment => SystemColor.DarkGreen;
    }
}

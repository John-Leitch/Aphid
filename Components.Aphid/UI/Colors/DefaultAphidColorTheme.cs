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
    public class DefaultAphidColorTheme : IAphidColorTheme
    {
        public byte[] GetBackground() => SystemColor.Black;

        public ColoredText GetColoredText(in AphidToken token) =>
            GetColoredText(token, None);

        public ColoredText GetColoredText(in AphidToken token, AphidTokenType nextType) =>
            new(GetColor(token.TokenType, nextType), token.Lexeme);

        public byte[] GetColor(AphidTokenType type) =>
            GetColor(type, None);

        public byte[] GetColor(AphidTokenType type, AphidTokenType nextType)
        {
            return type switch
            {
                AphidTokenType.String => SystemColor.Coral,
                Number or HexNumber or BinaryNumber => SystemColor.PaleGoldenrod,
                Identifier => nextType switch
                {
                    Identifier or
                        ImplicitArgumentOperator or
                        ImplicitArgumentsOperator or
                        PatternMatchingOperator or
                        BinaryNumber or
                        Number or
                        HexNumber => SystemColor.DodgerBlue,
                    _ => SystemColor.CadetBlue,
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
                    PatternMatchingOperator => SystemColor.DodgerBlue,
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
                    XorOperator => SystemColor.Silver,
                LeftBrace or
                    RightBrace or
                    LeftBracket or
                    RightBracket => SystemColor.LightGray,
                MemberOperator => SystemColor.White,
                RightParenthesis or
                    LeftParenthesis => SystemColor.LightGray,
                Comment => SystemColor.DarkGreen,
                _ => SystemColor.White,
            };
        }
    }
}

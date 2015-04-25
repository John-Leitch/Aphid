namespace Components.Aphid.Parser {
    using Components.Aphid.Lexer;
    
    
    public enum AphidExpressionType {
        
        BinaryOperatorExpression,
        
        UnaryOperatorExpression,
        
        CallExpression,
        
        TernaryOperatorExpression,
        
        ArrayAccessExpression,
        
        IdentifierExpression,
        
        IfExpression,
        
        DynamicMemberExpression,
        
        ExtendExpression,
        
        ForEachExpression,
        
        ForExpression,
        
        WhileExpression,
        
        DoWhileExpression,
        
        LoadScriptExpression,
        
        LoadLibraryExpression,
        
        TryExpression,
        
        SwitchExpression,
        
        SwitchCase,
        
        StringExpression,
        
        ObjectExpression,
        
        ArrayExpression,
        
        FunctionExpression,
        
        PartialFunctionExpression,
        
        PatternMatchingExpression,
        
        PatternExpression,
        
        NumberExpression,
        
        BooleanExpression,
        
        ThisExpression,
        
        NullExpression,
        
        BreakExpression,
    }
    
    public partial class AphidParser {
        
        public System.Collections.Generic.List<AphidExpression> Parse() {
            var expressionSequence = new System.Collections.Generic.List<AphidExpression>();
            NextToken();
            for (
            ; ((this._currentToken.TokenType == AphidTokenType.None) 
                        == false); 
            ) {
                expressionSequence.Add(ParseStatement());
            }
            return expressionSequence;
        }
        
        private AphidExpression ParseStatement() {
            AphidExpression exp = default(AphidExpression);
            if ((this._currentToken.TokenType == AphidTokenType.ifKeyword)) {
                exp = ParseIfExpression();
            }
            else {
                if ((this._currentToken.TokenType == AphidTokenType.forKeyword)) {
                    exp = ParseForExpression();
                }
                else {
                    if ((this._currentToken.TokenType == AphidTokenType.whileKeyword)) {
                        exp = ParseWhileExpression();
                    }
                    else {
                        if ((this._currentToken.TokenType == AphidTokenType.doKeyword)) {
                            exp = ParseDoWhileExpression();
                            if (true) {
                                Match(AphidTokenType.EndOfStatement);
                            }
                        }
                        else {
                            if ((this._currentToken.TokenType == AphidTokenType.extendKeyword)) {
                                exp = ParseExtendExpression();
                            }
                            else {
                                if ((this._currentToken.TokenType == AphidTokenType.tryKeyword)) {
                                    exp = ParseTryExpression();
                                }
                                else {
                                    if ((this._currentToken.TokenType == AphidTokenType.switchKeyword)) {
                                        exp = ParseSwitchExpression();
                                    }
                                    else {
                                        exp = ParseExpression();
                                        if (true) {
                                            Match(AphidTokenType.EndOfStatement);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return exp;
        }
        
        private AphidExpression ParseSingleStatement() {
            AphidExpression exp = default(AphidExpression);
            if ((this._currentToken.TokenType == AphidTokenType.ifKeyword)) {
                exp = ParseIfExpression();
            }
            else {
                if ((this._currentToken.TokenType == AphidTokenType.forKeyword)) {
                    exp = ParseForExpression();
                }
                else {
                    if ((this._currentToken.TokenType == AphidTokenType.whileKeyword)) {
                        exp = ParseWhileExpression();
                    }
                    else {
                        if ((this._currentToken.TokenType == AphidTokenType.doKeyword)) {
                            exp = ParseDoWhileExpression();
                            if (false) {
                                Match(AphidTokenType.EndOfStatement);
                            }
                        }
                        else {
                            if ((this._currentToken.TokenType == AphidTokenType.extendKeyword)) {
                                exp = ParseExtendExpression();
                            }
                            else {
                                if ((this._currentToken.TokenType == AphidTokenType.tryKeyword)) {
                                    exp = ParseTryExpression();
                                }
                                else {
                                    if ((this._currentToken.TokenType == AphidTokenType.switchKeyword)) {
                                        exp = ParseSwitchExpression();
                                    }
                                    else {
                                        exp = ParseExpression();
                                        if (false) {
                                            Match(AphidTokenType.EndOfStatement);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return exp;
        }
        
        private AphidExpression ParseExpression() {
            return ParseAssignmentExpression();
        }
        
        private AphidExpression ParseAssignmentExpression() {
            var operand = ParsePipelineExpression();
            for (
            ; (((((((((((this._currentToken.TokenType == AphidTokenType.AssignmentOperator) 
                        || (this._currentToken.TokenType == AphidTokenType.PlusEqualOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.MinusEqualOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.MultiplicationEqualOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.DivisionEqualOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.ModulusEqualOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.BinaryAndEqualOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.OrEqualOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.XorEqualOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.ShiftLeftEqualOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.ShiftRightEqualOperator)); 
            ) {
                var op = this._currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParsePipelineExpression());
            }
            return operand;
        }
        
        private AphidExpression ParsePipelineExpression() {
            var operand = ParseQueryExpression();
            for (
            ; (this._currentToken.TokenType == AphidTokenType.PipelineOperator); 
            ) {
                var op = this._currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseQueryExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseQueryExpression() {
            var exp = ParseRangeExpression();
            var inQuery = true;
            for (
            ; true; 
            ) {
                if ((((((this._currentToken.TokenType == AphidTokenType.AggregateOperator) 
                            || (this._currentToken.TokenType == AphidTokenType.AnyOperator)) 
                            || (this._currentToken.TokenType == AphidTokenType.SelectManyOperator)) 
                            || (this._currentToken.TokenType == AphidTokenType.SelectOperator)) 
                            || (this._currentToken.TokenType == AphidTokenType.WhereOperator))) {
                    var t = this._currentToken.TokenType;
                    NextToken();
                    exp = new BinaryOperatorExpression(exp, t, ParseRangeExpression());
                }
                else {
                    if ((this._currentToken.TokenType == AphidTokenType.DistinctOperator)) {
                        exp = new UnaryOperatorExpression(this._currentToken.TokenType, exp);
                        NextToken();
                    }
                    else {
                        inQuery = false;
                    }
                }
                if ((inQuery == false)) {
break;
                }
            }
            return exp;
        }
        
        private AphidExpression ParseRangeExpression() {
            var operand = ParseConditionalExpression();
            for (
            ; (this._currentToken.TokenType == AphidTokenType.RangeOperator); 
            ) {
                var op = this._currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseConditionalExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseConditionalExpression() {
            var exp = ParseLogicalExpression();
            if ((this._currentToken.TokenType == AphidTokenType.ConditionalOperator)) {
                NextToken();
                var trueExpression = ParseExpression();
                Match(AphidTokenType.ColonOperator);
                var falseExpression = ParseExpression();
                return new TernaryOperatorExpression(AphidTokenType.ConditionalOperator, exp, trueExpression, falseExpression);
            }
            else {
                return exp;
            }
        }
        
        private AphidExpression ParseLogicalExpression() {
            var operand = ParseComparisonExpression();
            for (
            ; ((this._currentToken.TokenType == AphidTokenType.AndOperator) 
                        || (this._currentToken.TokenType == AphidTokenType.OrOperator)); 
            ) {
                var op = this._currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseComparisonExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseComparisonExpression() {
            var operand = ParsePostfixUnaryOperationExpression();
            for (
            ; ((((((this._currentToken.TokenType == AphidTokenType.EqualityOperator) 
                        || (this._currentToken.TokenType == AphidTokenType.NotEqualOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.LessThanOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.LessThanOrEqualOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.GreaterThanOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.GreaterThanOrEqualOperator)); 
            ) {
                var op = this._currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParsePostfixUnaryOperationExpression());
            }
            return operand;
        }
        
        private AphidExpression ParsePostfixUnaryOperationExpression() {
            var term = ParseBinaryOrExpression();
            if (((this._currentToken.TokenType == AphidTokenType.IncrementOperator) 
                        || (this._currentToken.TokenType == AphidTokenType.DecrementOperator))) {
                var op = this._currentToken.TokenType;
                NextToken();
                return new UnaryOperatorExpression(op, term, true);
            }
            else {
                return term;
            }
        }
        
        private AphidExpression ParseBinaryOrExpression() {
            var operand = ParseXorExpression();
            for (
            ; (this._currentToken.TokenType == AphidTokenType.BinaryOrOperator); 
            ) {
                var op = this._currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseXorExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseXorExpression() {
            var operand = ParseBinaryAndExpression();
            for (
            ; (this._currentToken.TokenType == AphidTokenType.XorOperator); 
            ) {
                var op = this._currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseBinaryAndExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseBinaryAndExpression() {
            var operand = ParseShiftExpression();
            for (
            ; (this._currentToken.TokenType == AphidTokenType.BinaryAndOperator); 
            ) {
                var op = this._currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseShiftExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseShiftExpression() {
            var operand = ParseAdditionExpression();
            for (
            ; ((this._currentToken.TokenType == AphidTokenType.ShiftLeft) 
                        || (this._currentToken.TokenType == AphidTokenType.ShiftRight)); 
            ) {
                var op = this._currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseAdditionExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseAdditionExpression() {
            var operand = ParseTermExpression();
            for (
            ; ((this._currentToken.TokenType == AphidTokenType.AdditionOperator) 
                        || (this._currentToken.TokenType == AphidTokenType.MinusOperator)); 
            ) {
                var op = this._currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseTermExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseTermExpression() {
            var operand = ParsePrefixUnaryOperatorExpression();
            for (
            ; (((this._currentToken.TokenType == AphidTokenType.MultiplicationOperator) 
                        || (this._currentToken.TokenType == AphidTokenType.DivisionOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.ModulusOperator)); 
            ) {
                var op = this._currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParsePrefixUnaryOperatorExpression());
            }
            return operand;
        }
        
        private AphidExpression ParsePrefixUnaryOperatorExpression() {
            if ((((((((this._currentToken.TokenType == AphidTokenType.AdditionOperator) 
                        || (this._currentToken.TokenType == AphidTokenType.MinusOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.NotOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.IncrementOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.DecrementOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.MultiplicationOperator)) 
                        || (this._currentToken.TokenType == AphidTokenType.ComplementOperator))) {
                var t = this._currentToken.TokenType;
                NextToken();
                return new UnaryOperatorExpression(t, ParseArrayAccessExpression());
            }
            else {
                return ParseArrayAccessExpression();
            }
        }
        
        private AphidExpression ParseArrayAccessExpression() {
            var exp = ParseCallExpression();
            for (
            ; (this._currentToken.TokenType == AphidTokenType.LeftBracket); 
            ) {
                NextToken();
                var key = ParseExpression();
                Match(AphidTokenType.RightBracket);
                exp = new ArrayAccessExpression(exp, key);
            }
            return exp;
        }
        
        private AphidExpression ParseCallExpression() {
            var function = ParseMemberExpression();
            for (
            ; (this._currentToken.TokenType == AphidTokenType.LeftParenthesis); 
            ) {
                NextToken();
                if ((this._currentToken.TokenType == AphidTokenType.RightParenthesis)) {
                    NextToken();
                    function = new CallExpression(function);
                }
                else {
                    var args = ParseTuple();
                    Match(AphidTokenType.RightParenthesis);
                    function = new CallExpression(function, args);
                }
            }
            return function;
        }
        
        private AphidExpression ParseMemberExpression() {
            var factor = ParseFactorCallExpression();
            for (
            ; (this._currentToken.TokenType == AphidTokenType.MemberOperator); 
            ) {
                NextToken();
                AphidExpression exp = default(AphidExpression);
                if ((this._currentToken.TokenType == AphidTokenType.Identifier)) {
                    exp = new IdentifierExpression(this._currentToken.Lexeme);
                    NextToken();
                }
                else {
                    if ((this._currentToken.TokenType == AphidTokenType.String)) {
                        exp = ParseStringExpression();
                    }
                    else {
                        if ((this._currentToken.TokenType == AphidTokenType.LeftBrace)) {
                            NextToken();
                            exp = new DynamicMemberExpression(ParseExpression());
                            Match(AphidTokenType.RightBrace);
                        }
                        else {
                            throw new AphidParserException(_currentToken);
                        }
                    }
                }
                factor = new BinaryOperatorExpression(factor, AphidTokenType.MemberOperator, exp);
                for (
                ; (this._currentToken.TokenType == AphidTokenType.LeftParenthesis); 
                ) {
                    NextToken();
                    if ((this._currentToken.TokenType == AphidTokenType.RightParenthesis)) {
                        NextToken();
                        factor = new CallExpression(factor);
                    }
                    else {
                        var args = ParseTuple();
                        Match(AphidTokenType.RightParenthesis);
                        factor = new CallExpression(factor, args);
                    }
                }
                if ((this._currentToken.TokenType == AphidTokenType.definedKeyword)) {
                    NextToken();
                    return new UnaryOperatorExpression(AphidTokenType.definedKeyword, factor, true);
                }
            }
            return factor;
        }
        
        private AphidExpression ParseFactorCallExpression() {
            var function = ParseFactorExpression();
            for (
            ; (this._currentToken.TokenType == AphidTokenType.LeftParenthesis); 
            ) {
                NextToken();
                if ((this._currentToken.TokenType == AphidTokenType.RightParenthesis)) {
                    NextToken();
                    function = new CallExpression(function);
                }
                else {
                    var args = ParseTuple();
                    Match(AphidTokenType.RightParenthesis);
                    function = new CallExpression(function, args);
                }
            }
            return function;
        }
        
        private AphidExpression ParseStringExpression() {
            var exp = new StringExpression(this._currentToken.Lexeme);
            NextToken();
            return exp;
        }
        
        private IdentifierExpression ParseIdentifierExpression() {
            var exp = new IdentifierExpression(this._currentToken.Lexeme);
            NextToken();
            if ((this._currentToken.TokenType == AphidTokenType.Identifier)) {
                var id = exp;
                var attrs = new System.Collections.Generic.List<IdentifierExpression>();
                for (
                ; true; 
                ) {
                    attrs.Add(id);
                    id = new IdentifierExpression(this._currentToken.Lexeme);
                    NextToken();
                    if (((this._currentToken.TokenType == AphidTokenType.Identifier) 
                                == false)) {
break;
                    }
                }
                exp = new IdentifierExpression(id.Identifier, attrs);
            }
            return exp;
        }
        
        private AphidExpression ParseUnaryExpression() {
            var t = this._currentToken.TokenType;
            NextToken();
            return new UnaryOperatorExpression(t, ParseExpression());
        }
        
        private AphidExpression ParseCondition() {
            Match(AphidTokenType.LeftParenthesis);
            var condition = ParseExpression();
            Match(AphidTokenType.RightParenthesis);
            return condition;
        }
        
        private AphidExpression ParseIfExpression() {
            NextToken();
            var condition = ParseCondition();
            var body = ParseBlock();
            System.Collections.Generic.List<AphidExpression> elseBody = default(System.Collections.Generic.List<AphidExpression>);
            if ((this._currentToken.TokenType == AphidTokenType.elseKeyword)) {
                NextToken();
                elseBody = ParseBlock();
            }
            return new IfExpression(condition, body, elseBody);
        }
        
        private System.Collections.Generic.List<AphidExpression> ParseBlock() {
            var statements = new System.Collections.Generic.List<AphidExpression>();
            if ((this._currentToken.TokenType == AphidTokenType.LeftBrace)) {
                NextToken();
                for (
                ; ((this._currentToken.TokenType == AphidTokenType.RightBrace) 
                            == false); 
                ) {
                    statements.Add(ParseStatement());
                }
                NextToken();
            }
            else {
                statements.Add(ParseStatement());
            }
            return statements;
        }
        
        private System.Collections.Generic.List<AphidExpression> ParseSingleBlock() {
            var statements = new System.Collections.Generic.List<AphidExpression>();
            if ((this._currentToken.TokenType == AphidTokenType.LeftBrace)) {
                NextToken();
                for (
                ; ((this._currentToken.TokenType == AphidTokenType.RightBrace) 
                            == false); 
                ) {
                    statements.Add(ParseStatement());
                }
                NextToken();
            }
            else {
                statements.Add(ParseSingleStatement());
            }
            return statements;
        }
        
        private AphidExpression ParseExtendExpression() {
            NextToken();
            return new ExtendExpression(ParseIdentifierExpression().Identifier, ParseObjectExpression());
        }
        
        private AphidExpression ParseForExpression() {
            NextToken();
            Match(AphidTokenType.LeftParenthesis);
            var initOrElement = ParseExpression();
            if ((this._currentToken.TokenType == AphidTokenType.inKeyword)) {
                NextToken();
                var collection = ParseExpression();
                Match(AphidTokenType.RightParenthesis);
                var body = ParseBlock();
                return new ForEachExpression(collection, initOrElement, body);
            }
            else {
                Match(AphidTokenType.EndOfStatement);
                var condition = ParseExpression();
                Match(AphidTokenType.EndOfStatement);
                var afterthought = ParseExpression();
                Match(AphidTokenType.RightParenthesis);
                var body = ParseBlock();
                return new ForExpression(initOrElement, condition, afterthought, body);
            }
        }
        
        private AphidExpression ParseWhileExpression() {
            NextToken();
            return new WhileExpression(ParseCondition(), ParseBlock());
        }
        
        private AphidExpression ParseDoWhileExpression() {
            NextToken();
            var body = ParseBlock();
            Match(AphidTokenType.whileKeyword);
            Match(AphidTokenType.LeftParenthesis);
            var condition = ParseExpression();
            Match(AphidTokenType.RightParenthesis);
            return new DoWhileExpression(condition, body);
        }
        
        private System.Collections.Generic.List<AphidExpression> ParseTuple() {
            var tuple = new System.Collections.Generic.List<AphidExpression>();
            for (
            ; true; 
            ) {
                tuple.Add(ParseExpression());
                if ((this._currentToken.TokenType == AphidTokenType.Comma)) {
                    NextToken();
                }
                else {
                    return tuple;
                }
            }
        }
        
        private AphidExpression ParseLoadScriptExpression() {
            NextToken();
            return new LoadScriptExpression(ParseExpression());
        }
        
        private AphidExpression ParseLoadLibraryExpression() {
            NextToken();
            return new LoadLibraryExpression(ParseExpression());
        }
        
        private AphidExpression ParseTryExpression() {
            NextToken();
            var tryBody = ParseBlock();
            IdentifierExpression catchArg = default(IdentifierExpression);
            System.Collections.Generic.List<AphidExpression> catchBody = default(System.Collections.Generic.List<AphidExpression>);
            System.Collections.Generic.List<AphidExpression> finallyBody = default(System.Collections.Generic.List<AphidExpression>);
            if ((this._currentToken.TokenType == AphidTokenType.catchKeyword)) {
                NextToken();
                Match(AphidTokenType.LeftParenthesis);
                catchArg = ParseIdentifierExpression();
                Match(AphidTokenType.RightParenthesis);
                catchBody = ParseBlock();
                if ((this._currentToken.TokenType == AphidTokenType.finallyKeyword)) {
                    NextToken();
                    finallyBody = ParseBlock();
                }
            }
            else {
                if ((this._currentToken.TokenType == AphidTokenType.finallyKeyword)) {
                    NextToken();
                    finallyBody = ParseBlock();
                }
                else {
                    throw new AphidParserException(_currentToken);
                }
            }
            return new TryExpression(tryBody, catchArg, catchBody, finallyBody);
        }
        
        private AphidExpression ParseSwitchExpression() {
            NextToken();
            Match(AphidTokenType.LeftParenthesis);
            var exp = ParseExpression();
            Match(AphidTokenType.RightParenthesis);
            Match(AphidTokenType.LeftBrace);
            var cases = new System.Collections.Generic.List<SwitchCase>();
            System.Collections.Generic.List<AphidExpression> defaultCase = default(System.Collections.Generic.List<AphidExpression>);
            for (
            ; ((this._currentToken.TokenType == AphidTokenType.RightBrace) 
                        == false); 
            ) {
                if (((this._currentToken.TokenType == AphidTokenType.defaultKeyword) 
                            == false)) {
                    var caseTuple = ParseTuple();
                    Match(AphidTokenType.ColonOperator);
                    var block = ParseBlock();
                    cases.Add(new SwitchCase(caseTuple, block));
                }
                else {
                    NextToken();
                    Match(AphidTokenType.ColonOperator);
                    defaultCase = ParseBlock();
                }
            }
            NextToken();
            return new SwitchExpression(exp, cases, defaultCase);
        }
        
        private ObjectExpression ParseObjectExpression() {
            NextToken();
            var inNode = true;
            var childNodes = new System.Collections.Generic.List<BinaryOperatorExpression>();
            for (
            ; inNode; 
            ) {
                if ((this._currentToken.TokenType == AphidTokenType.Identifier)) {
                    childNodes.Add(ParseKeyValuePairExpression());
                    if ((this._currentToken.TokenType == AphidTokenType.Comma)) {
                        NextToken();
                    }
                    else {
                        if ((this._currentToken.TokenType == AphidTokenType.RightBrace)) {
                            NextToken();
                            inNode = false;
                        }
                        else {
                            throw new AphidParserException(_currentToken);
                        }
                    }
                }
                else {
                    if ((this._currentToken.TokenType == AphidTokenType.RightBrace)) {
                        NextToken();
                        inNode = false;
                    }
                    else {
                        throw new AphidParserException(_currentToken);
                    }
                }
            }
            return new ObjectExpression(childNodes);
        }
        
        private AphidExpression ParseArrayExpression() {
            NextToken();
            var inNode = true;
            var childNodes = new System.Collections.Generic.List<AphidExpression>();
            if (((this._currentToken.TokenType == AphidTokenType.RightBracket) 
                        == false)) {
                for (
                ; inNode; 
                ) {
                    childNodes.Add(ParseExpression());
                    if ((this._currentToken.TokenType == AphidTokenType.Comma)) {
                        NextToken();
                        if ((this._currentToken.TokenType == AphidTokenType.RightBracket)) {
                            NextToken();
                            inNode = false;
                        }
                    }
                    else {
                        if ((this._currentToken.TokenType == AphidTokenType.RightBracket)) {
                            NextToken();
                            inNode = false;
                        }
                        else {
                            throw new AphidParserException(_currentToken);
                        }
                    }
                }
            }
            else {
                NextToken();
            }
            return new ArrayExpression(childNodes);
        }
        
        private BinaryOperatorExpression ParseKeyValuePairExpression() {
            var id = ParseIdentifierExpression();
            AphidExpression exp = default(AphidExpression);
            if (((this._currentToken.TokenType == AphidTokenType.ColonOperator) 
                        || (this._currentToken.TokenType == AphidTokenType.AssignmentOperator))) {
                NextToken();
                exp = ParseExpression();
            }
            else {
                exp = id;
            }
            return new BinaryOperatorExpression(id, AphidTokenType.ColonOperator, exp);
        }
        
        private AphidExpression ParseNumberExpression() {
            var exp = new NumberExpression(decimal.Parse(this._currentToken.Lexeme));
            NextToken();
            return exp;
        }
        
        private AphidExpression ParseFunctionExpression() {
            AphidExpression exp = default(AphidExpression);
            var body = new System.Collections.Generic.List<AphidExpression>();
            var args = new System.Collections.Generic.List<AphidExpression>();
            AphidExpression argExp = default(AphidExpression);
            NextToken();
            if ((this._currentToken.TokenType == AphidTokenType.LeftParenthesis)) {
                NextToken();
                if (((this._currentToken.TokenType == AphidTokenType.RightParenthesis) 
                            == false)) {
                    for (
                    ; true; 
                    ) {
                        if ((this._currentToken.TokenType == AphidTokenType.Identifier)) {
                            var id = ParseIdentifierExpression();
                            argExp = id;
                            if ((this._currentToken.TokenType == AphidTokenType.AssignmentOperator)) {
                                var op = this._currentToken.TokenType;
                                NextToken();
                                argExp = new BinaryOperatorExpression(id, op, ParseExpression());
                            }
                            args.Add(argExp);
                            if ((this._currentToken.TokenType == AphidTokenType.Comma)) {
                                NextToken();
                            }
                            else {
break;
                            }
                        }
                        else {
                            throw new AphidParserException(_currentToken);
                        }
                    }
                }
                Match(AphidTokenType.RightParenthesis);
                var isSingleLine = (this._currentToken.TokenType != AphidTokenType.LeftBrace);
                var block = ParseSingleBlock();
                if ((isSingleLine && UseImplicitReturns)) {
                    body.Add(new UnaryOperatorExpression(AphidTokenType.retKeyword, block[0]));
                }
                else {
                    body = block;
                }
                exp = new FunctionExpression(args, body);
            }
            else {
                exp = new PartialFunctionExpression(ParseCallExpression());
            }
            return exp;
        }
        
        private AphidExpression ParsePatternMatchingExpression() {
            NextToken();
            var patterns = new System.Collections.Generic.List<PatternExpression>();
            Match(AphidTokenType.LeftParenthesis);
            var testExp = ParseExpression();
            Match(AphidTokenType.RightParenthesis);
            for (
            ; true; 
            ) {
                var tuple = new System.Collections.Generic.List<AphidExpression>();
                for (
                ; true; 
                ) {
                    tuple.Add(ParseExpression());
                    if ((this._currentToken.TokenType == AphidTokenType.Comma)) {
                        NextToken();
                    }
                    else {
break;
                    }
                }
                AphidExpression valueExp = default(AphidExpression);
                if ((this._currentToken.TokenType == AphidTokenType.ColonOperator)) {
                    NextToken();
                    valueExp = ParseExpression();
                    patterns.Add(new PatternExpression(tuple, valueExp));
                }
                else {
                    if ((tuple.Count != 1)) {
                        throw new AphidParserException(_currentToken);
                    }
                    patterns.Add(new PatternExpression(tuple[0]));
                }
                if ((this._currentToken.TokenType == AphidTokenType.Comma)) {
                    NextToken();
                }
                else {
break;
                }
            }
            return new PatternMatchingExpression(testExp, patterns);
        }
        
        private AphidExpression ParseFactorExpression() {
            AphidExpression exp = default(AphidExpression);
            if ((this._currentToken.TokenType == AphidTokenType.LeftBrace)) {
                exp = ParseObjectExpression();
            }
            else {
                if ((this._currentToken.TokenType == AphidTokenType.LeftBracket)) {
                    exp = ParseArrayExpression();
                }
                else {
                    if ((this._currentToken.TokenType == AphidTokenType.LeftParenthesis)) {
                        NextToken();
                        exp = ParseExpression();
                        Match(AphidTokenType.RightParenthesis);
                    }
                    else {
                        if ((this._currentToken.TokenType == AphidTokenType.String)) {
                            exp = ParseStringExpression();
                        }
                        else {
                            if ((this._currentToken.TokenType == AphidTokenType.Number)) {
                                exp = ParseNumberExpression();
                            }
                            else {
                                if ((this._currentToken.TokenType == AphidTokenType.Identifier)) {
                                    exp = ParseIdentifierExpression();
                                    if ((this._currentToken.TokenType == AphidTokenType.definedKeyword)) {
                                        NextToken();
                                        exp = new UnaryOperatorExpression(AphidTokenType.definedKeyword, exp, true);
                                    }
                                }
                                else {
                                    if ((this._currentToken.TokenType == AphidTokenType.functionOperator)) {
                                        exp = ParseFunctionExpression();
                                    }
                                    else {
                                        if (((this._currentToken.TokenType == AphidTokenType.retKeyword) 
                                                    || (this._currentToken.TokenType == AphidTokenType.deleteKeyword))) {
                                            exp = ParseUnaryExpression();
                                        }
                                        else {
                                            if ((this._currentToken.TokenType == AphidTokenType.trueKeyword)) {
                                                exp = new BooleanExpression(true);
                                                NextToken();
                                            }
                                            else {
                                                if ((this._currentToken.TokenType == AphidTokenType.falseKeyword)) {
                                                    exp = new BooleanExpression(false);
                                                    NextToken();
                                                }
                                                else {
                                                    if ((this._currentToken.TokenType == AphidTokenType.thisKeyword)) {
                                                        exp = new ThisExpression();
                                                        NextToken();
                                                    }
                                                    else {
                                                        if ((this._currentToken.TokenType == AphidTokenType.LoadScriptOperator)) {
                                                            exp = ParseLoadScriptExpression();
                                                        }
                                                        else {
                                                            if ((this._currentToken.TokenType == AphidTokenType.LoadLibraryOperator)) {
                                                                exp = ParseLoadLibraryExpression();
                                                            }
                                                            else {
                                                                if ((this._currentToken.TokenType == AphidTokenType.nullKeyword)) {
                                                                    exp = new NullExpression();
                                                                    NextToken();
                                                                }
                                                                else {
                                                                    if ((this._currentToken.TokenType == AphidTokenType.breakKeyword)) {
                                                                        exp = new BreakExpression();
                                                                        NextToken();
                                                                    }
                                                                    else {
                                                                        if ((this._currentToken.TokenType == AphidTokenType.HexNumber)) {
                                                                            exp = new NumberExpression(System.Convert.ToInt64(_currentToken.Lexeme.Substring(2), 16));
                                                                            NextToken();
                                                                        }
                                                                        else {
                                                                            if ((this._currentToken.TokenType == AphidTokenType.BinaryNumber)) {
                                                                                exp = new NumberExpression(BinaryNumber.Parse(_currentToken.Lexeme.Substring(2)));
                                                                                NextToken();
                                                                            }
                                                                            else {
                                                                                if ((this._currentToken.TokenType == AphidTokenType.PatternMatchingOperator)) {
                                                                                    exp = ParsePatternMatchingExpression();
                                                                                }
                                                                                else {
                                                                                    throw new AphidParserException(_currentToken);
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return exp;
        }
    }
}

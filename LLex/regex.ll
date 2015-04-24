LLex.Regex

Regex

\(          LeftParenthesis
\)          RightParenthesis
\[          LeftBracket
\]          RightBracket            
\|          OrOperator
\?          ZeroOrOneQuantifier
\*          ZeroOrMoreQuantifier
\+          OneOrMoreQuantifier   

\\s         SpecialCharacter
\\r			SpecialCharacter
\\n         SpecialCharacter
\\t			SpecialCharacter
\\v			SpecialCharacter 

\\\(        Character
\\\)        Character
\\\[        Character
\\\]        Character            
\\\|        Character
\\\?        Character
\\\*        Character
\\\+        Character
\\\\        Character

%%
	return RegexTokenType.Character;
%%
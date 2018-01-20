var index = lastIndex + 1;
var lexeme = text.Substring(index, charIndex - lastIndex);

tokens.Add(new {Token}(tokenType, lexeme, index));

using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public class AphidScriptOptimizer
    {
        private AphidLoader _loader;

        public AphidScriptOptimizer(AphidLoader loader)
        {
            _loader = loader;
        }

        public List<AphidExpression> Optimize(string script)
        {
            var ast = AphidParser.Parse(script, isTextDocument: false);

            return Optimize(ast);            
        }

        public List<AphidExpression> Optimize(List<AphidExpression> ast)
        {
            var optimizedAst = new List<AphidExpression>();

            foreach (var exp in ast)
            {
                var loadExp = exp as LoadScriptExpression;

                if (loadExp != null && loadExp.FileExpression is StringExpression)
                {
                    var filename = StringParser.Parse(((StringExpression)loadExp.FileExpression).Value);
                    filename = _loader.FindScriptFile(null, filename);

                    var childAst = Optimize(File.ReadAllText(filename));
                    optimizedAst.AddRange(childAst);
                }
                else
                {
                    optimizedAst.Add(exp);
                }
            }

            return optimizedAst;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Grammars;
using Lexer;

namespace Core
{
    class CoolLexer : ILexer<Token>
    {
        private readonly LexerEngine _engine;

        public CoolLexer()
        {
            var regex = new List<(string, string)>
            {
                ("[cC][lL][aA][sS][sS]", "class"),
                ("[iI][nN][hH][eE][rR][iI][tT][sS]", "inherits"),
                (";", ";"),
                ("\\(", "("),
                ("\\)", ")"),
                (",", ","),
                (":", ":"),
                (".", "."),
                ("{", "{"),
                ("}", "}"),
                ("<\\-", "<-"),
                ("[iI][fF]", "if"),
                ("[tT][hH][eE][nN]", "then"),
                ("@", "@"),
                ("[eE][lL][sS][eE]", "else"),
                ("[fF][iI]", "fi"),
                ("[wW][hH][iI][lL][eE]", "while"),
                ("[lL][oO][oO][pP]", "loop"),
                ("[pP][oO][oO][lL]", "pool"),
                ("[lL][eE][tT]", "let"),
                ("[iI][nN]", "in"),
                ("[cC][aA][sS][eE]", "case"),
                ("[oO][fF]", "of"),
                ("=>", "=>"),
                ("[eE][sS][aA][cC]", "esac"),
                ("[nN][eE][wW]", "new"),
                ("[iI][sS][vV][oO][iI][dD]", "isvoid"),
                ("[vV][oO][iI][dD]", "void"),
                ("\\+", "+"),
                ("\\-", "-"),
                ("\\*", "*"),
                ("/", "/"),
                ("~", "~"),
                ("<", "<"),
                ("<=", "<="),
                ("=", "="),
                ("not", "not"),
                ("[0-9]*", "integer"),
                ("[tT][rR][uU][eE]", "true"),
                ("[fF][aA][lL][Ss][eE]", "false"),
                ("[A-Z][_a-zA-Z0-9]*", "TYPE"),
                ("[a-z][_a-zA-Z0-9]*", "ID"),
                ("\"", "strdelimiter"),
                ("\\-\\-", "lineComment"),
                ("\\(\\*", "blockCommentInit"),
                ("\\*\\)", "blockCommentEnd"),
                ("\b", "backspace"),
                ("[ \f\t\r]*", "spaces"),
                ("\n*", "newline"),
                ("\0", "0"),
                ("\\\\", "\\")
            };
            _engine = new LexerEngine(regex);
        }

        public IEnumerable<Token> Lex(string str, Grammar g)
        {
            throw new NotImplementedException();
        }
    }
}
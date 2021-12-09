using System;
using System.Collections.Generic;
using System.Linq;

namespace Yapp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("> ");
                
                var line = Console.ReadLine();
                if (line == null) continue;
                var tokens = Tokenize(line);
                
                foreach (var token in tokens)
                {
                    Console.WriteLine(token);
                }
            }
        }

        private static List<Token> Tokenize(string line)
        {
            string[] lexemes = line.Split(' ');
            return lexemes.Select((lexeme, i) => new Token(lexeme, i)).ToList();
        }
    }

    enum TokenType
    {
        NUMBER,
        PLUS,
        MINUS,
        PRINT,
    }

    class Token
    {
        public TokenType Type { get; }
        public int Index { get; }
        public string Lexeme { get; }
        
        public Token(string lexeme, int index)
        {
            this.Type = LexemeToTokenType(lexeme);
            this.Index = index;
            this.Lexeme = lexeme;
        }

        public override string ToString()
        {
            return $"Token {this.Type.ToString()} (index { this.Index.ToString()}): {this.Lexeme}";
        }

        private TokenType LexemeToTokenType(string lexeme)
        {
            if (int.TryParse(lexeme, out _))
                return TokenType.NUMBER;
            
            switch (lexeme)
            {
                case "+":
                    return TokenType.PLUS;
                case "-":
                    return TokenType.MINUS;
                case "print":
                    return TokenType.PRINT;
                default:
                    throw new Exception("Could not find TokenType " + lexeme);
            }
        }
    }
}
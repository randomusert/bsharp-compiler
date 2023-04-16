using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("bsharp(beta)>");
                var line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line)) 
                {
                    return;
                }
                if (line == "1 + 2 * 3") 
                {
                    Console.WriteLine("9"); 
                }
                else 
                {
                    Console.WriteLine("ERROR!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                }
            }
        }
    }
    class SyntaxToken
    {
        public SyntaxToken(SyntaxKind kind,int position, string text)
        {
            
        }
    }

    enum SyntaxKind
    {
    }

    class Lexer
    {
        private readonly string _text;
        private int _position;
        public Lexer(string _text)
        {
            Text = _text;
        }

        public SyntaxToken NextToken() { }
        public string Text { get; }
    }
}

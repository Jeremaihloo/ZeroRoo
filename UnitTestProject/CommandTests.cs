using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeroRoo.Laughing;
using System.Diagnostics;
using ZeroRoo.Command;

namespace UnitTestProject
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void CommandLexerTest()
        {
            var commandLine = "hello lujiejie -p \"test haha\" -c /etc/config.json --getfile";
            Lexer lexer = new Lexer(commandLine);
            while (true)
            {
                var token = lexer.Next();
                if (token.Type == TokenType.EOF)
                {
                    break;
                }
                Trace.WriteLine(string.Format("Position: {0} Data:{1} Type: {2}", token.Position, token.Data, token.Type));
            }
        }
    }
}

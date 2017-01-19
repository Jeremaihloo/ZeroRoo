using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeroRoo.Laughing;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    public class LaughingTests
    {
        [TestMethod]
        public void LexerTest()
        {
            var source = @"#!/usr/bin/laughing
                            let a = 1
                            let b = 19;
                            let c = a + b
                            print(c)
                            if(c>10){
                                print('c>10')
                            }else{
                                print('c<=10')
                            }

                            for(let i=0;i<10;i++){
                                print(i)
                                run('ls /usr/bin/' + i)
                            }";
            LaughingLexer lexer = new LaughingLexer(source);
            while (true)
            {
                var token = lexer.Next();
                if (token.TokenKind == TokenKind.EOF)
                {
                    break;
                }
                Trace.WriteLine(string.Format("TokenKind: {0} Row: {1} Col:{2} Data:{3} ", token.TokenKind.ToString().PadRight(20,' '), token.Line.ToString().PadRight(20, ' '), token.Col.ToString().PadRight(20, ' '), token.Data.ToString().PadRight(20, ' ')));
            }
        }
    }
}

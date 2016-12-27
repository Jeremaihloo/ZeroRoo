using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Command
{
    public enum TokenType
    {
        Text,
        ConfigKeyFlag,
        OptionFlag,
        StringStart,
        StringEnd,
        EOF
    }

    public enum LexMode
    {
        Text,
        String,
        EOF
    }

    public class Token
    {
        public int Position { get; set; }

        public TokenType Type { get; set; }

        public string Data { get; set; }
    }

    public class CommandParser
    {
        public CommandExcuteEntry Parse(string cmdLine)
        {
            throw new NotImplementedException();
        }
        
    }

    public class Grammer
    {
        private Lexer lexer;
        public Grammer(Lexer lexer)
        {
            this.lexer = lexer;
        }

        int pos;
        List<Token> list = new List<Token>();

        public CommandExcuteEntry Parse()
        {
            while(true)
            {
                var token = this.lexer.Next();
                if (token.Type == TokenType.EOF)
                {
                    break;
                }
                list.Add(token);
            }

            if(this.list[0].Type != TokenType.Text)
            {
                throw new Exception("command name not found");
            }

            var entry = new CommandExcuteEntry();
            entry.Name = this.list[0].Data;

            pos = 1;
            while(pos<this.list.Count-1)
            {
                if(this.list[pos].Type== TokenType.Text)
                {
                    entry.SubCommand = this.list[pos].Data;
                }
                if(this.list[pos].Type== TokenType.StringStart)
                {
                   
                }
            }
            return entry;
        }
        
    }

    public class Lexer
    {
        const char EOF = (char)0;

        public Lexer(string text)
        {
            this.text = text;
            this.reset();
        }

        public Token Next()
        {
            switch(currentMode)
            {
                case LexMode.Text:
                    return nextText();
                case LexMode.String:
                    return nextString();
                case LexMode.EOF:
                    return new Token() { Type = TokenType.EOF };
                default:
                    throw new Exception();
            }
        }

        char LA(int count)
        {
            if (currentPos + count > this.text.Length - 1)
            {
                return EOF;
            }
            return this.text[currentPos + count];
        }

        Token nextText()
        {
            startRead();
        StartTextRead:
            char ch = LA(0);
            switch (ch)
            {
                case '-':
                    if (LA(1) == '-')
                    {
                        consume(2);
                        return createToken(TokenType.OptionFlag);
                    }
                    else
                    {
                        consume();
                        return createToken(TokenType.ConfigKeyFlag);
                    }
                case ' ':
                    consume();
                    return createToken(TokenType.Text);
                case EOF:
                    leaveMode();
                    return createToken(TokenType.EOF);
                case '"':
                    if (LA(1) == '"')
                    {
                        consume(2);
                        return createToken(TokenType.StringStart);
                    }
                    consume();
                    enterMode(LexMode.String);
                    return createToken(TokenType.StringStart);
                default:
                    if (LA(1) == EOF)
                    {
                        consume();
                        leaveMode();
                        return createToken(TokenType.Text);
                    }
                    consume();
                    goto StartTextRead;
            }
        }
        
        Token nextString()
        {
            startRead();
        StartStringRead:
            var ch = LA(0);
            switch(ch)
            {
                case '"':
                    if (savePos != currentPos)
                    {
                        consume();
                        leaveMode();
                        return createToken(TokenType.StringEnd);
                    }
                    else
                    {
                        consume();
                        goto StartStringRead;
                    }
                case ' ':
                    consume();
                    leaveMode();
                    return nextText();
                case EOF:
                    leaveMode();
                    return createToken(TokenType.EOF);
                default:
                    consume();
                    goto StartStringRead;
            }
        }

        Token createToken(TokenType type)
        {
            var token = new Token();
            token.Type = type;
            token.Data = this.text.Substring(savePos, currentPos - savePos);
            token.Position = savePos;
            startRead();
            return token;
        }

        string text;
        int currentPos;
        int savePos;
        LexMode currentMode;
        Stack<LexMode> mode;

        void consume(int count = 1)
        {
            currentPos += count;
        }

        void startRead()
        {
            savePos = currentPos;
        }

        void reset()
        {
            this.currentMode = LexMode.Text;
            this.currentPos = 0;
            this.savePos = 1;
            this.mode = new Stack<LexMode>();
            this.mode.Push(this.currentMode);
        }

        void enterMode(LexMode mode)
        {
            this.currentMode = mode;
            this.mode.Push(mode);
        }

        void leaveMode()
        {
            if (this.mode.Count == 0)
            {
                this.currentMode = LexMode.EOF;
            }
            else
            {
                this.currentMode = this.mode.Pop();
            }
        }
    }
}

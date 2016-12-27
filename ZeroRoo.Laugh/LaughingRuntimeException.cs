/*****************************************************
 * 本类库的核心系 AderTemplates
 * (C) Andrew Deren 2004
 * http://www.adersoftware.com
 *****************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroRoo.Laughing
{
    public class LaughingRuntimeException : Exception
    {
        int line;
        int col;

        public LaughingRuntimeException(string msg, int line, int col)
            : base(msg)
        {
            this.line = line;
            this.col = col;
        }

        public LaughingRuntimeException(string msg, Exception innerException, int line, int col)
            : base(msg, innerException)
        {
            this.line = line;
            this.col = col;
        }

        public int Col
        {
            get { return this.col; }
        }

        public int Line
        {
            get { return this.line; }
        }
    }
}

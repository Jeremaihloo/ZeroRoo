/*****************************************************
 * 本类库的核心系 AderTemplates
 * (C) Andrew Deren 2004
 * http://www.adersoftware.com
 *****************************************************/

#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ZeroRoo.Laughing
{
    public class ParseException : Exception
    {
        int line;
        int col;

        public ParseException(string msg, int line, int col)
            : base(string.Format("{0} Line: {1} Col: {2}", msg, line, col))
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

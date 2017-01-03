using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Q.Core
{
    public delegate void SelectKeyChangedHandler(object sender, SelectKeyChangedEventArgs e);


    public class SelectKeyChangedEventArgs : EventArgs
    {
        public string Char { get; set; }

        public SelectKeyChangedEventArgs(string charContent)
        {
            this.Char = charContent;
        }
    }
}

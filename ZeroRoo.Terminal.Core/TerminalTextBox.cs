using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Q.Controls;

namespace ZeroRoo.Terminal.Core
{
    public class TerminalTextBox: DSkin.DirectUI.DuiTextBox
    {
        public enum InputType
        {
            None = 0,
            Command = 1
        }
        
        public InputType CurrentInputType { get; set; }

        public string CommandLineStart { get; set; }

        public int CommandLineStartIndex { get; set; }

        public TerminalTextBox()
        {
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
            this.CaretColor = Color.White;

            this.CommandLineStart = "$ ";
            this.CurrentInputType = InputType.Command;
            
        }
        
        public delegate void CommandLineHandler(TerminalTextBox box, string commandLine);

        public event CommandLineHandler NewLineSubmit;

        public event CommandLineHandler TabCommand;

        public void NewCommandLine()
        {
            this.InsertText(this.CommandLineStart);
            this.CommandLineStartIndex = this.Text.Length - 1;
        }
        
        public bool IsInCommandLine
        {
            get { return this.RowCount - 1 == this.GetLineIndex(Cursor.Position); }
        }

        public bool IsInCommandLineStart
        {
            get { return this.CaretIndex == this.CommandLineStartIndex + 1; }
        }

        public string CommandLine
        {
            get
            { 
                return this.Text.Substring(this.CommandLineStartIndex, this.Text.Length - this.CommandLineStartIndex);
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                if (this.IsInCommandLine)
                {
                    this.TabCommand?.Invoke(this, this.CommandLine);
                    return;

                }
            }
            base.OnKeyPress(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Back:
                    if (!this.IsInCommandLineStart && this.IsInCommandLine)
                    {
                       base.OnKeyDown(e);
                    }
                    break;
                default:
                    base.OnKeyDown(e);
                    break;
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if(this.IsInCommandLine)
                    {
                        base.OnKeyUp(e);
                        this.NewLineSubmit?.Invoke(this, this.CommandLine);
                    }
                    break;
                case Keys.Up:
                    if(this.IsInCommandLine)
                    {
                        MessageBox.Show("up");
                    }
                    break;
                case Keys.Left:
                    if(this.IsInCommandLineStart)
                    {

                    }
                    break;
                default:
                    base.OnKeyUp(e);
                    break;
            }
        }
    }
}

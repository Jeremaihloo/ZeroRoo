using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZeroRoo.Launcher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();

            this.Load += Launcher_Load;
        }

        void Launcher_Load(object sender, EventArgs e)
        {
            var dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            var dirList = dir.GetDirectories();
            var startDir = dirList[0];
            if (dirList.Length == 1)
            {
                Process.Start(Path.Combine(Directory.GetCurrentDirectory(), startDir.FullName));
                this.Close();
            }
            for (var i = 1; i < dirList.Length; i++)
            {
                if (int.Parse(dirList[i].FullName) > int.Parse(startDir.FullName))
                {
                    startDir = dirList[i];
                }
            }

            Process.Start(Path.Combine(Directory.GetCurrentDirectory(), startDir.FullName));
            this.Close();
        }

    }
}

using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeroRoo.Docker.Shapes
{
    public partial class Dashboard : Form
    {
        private readonly ChromiumWebBrowser browser;

        public Dashboard()
        {
            InitializeComponent();

            this.Size = Screen.GetWorkingArea(this).Size;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(0, 0);

            browser = new ChromiumWebBrowser("www.baidu.com")
            {
                Dock = DockStyle.Fill,
            };

            browser.RegisterAsyncJsObject("engine", new ZeroRooJsBradge()); //Standard object rego

            // browser.LoadingStateChanged += OnLoadingStateChanged;
            // browser.ConsoleMessage += OnBrowserConsoleMessage;
            this.Controls.Add(browser);
        }

    }
}

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
using Microsoft.Extensions.DependencyInjection;
using CefSharp;
using System.IO;

namespace ZeroRoo.Docker.Shapes
{
    public partial class Dashboard : Form
    {
        private readonly ChromiumWebBrowser browser;

        public Dashboard()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(0, 0);
            this.WindowState = FormWindowState.Maximized;

            browser = new ChromiumWebBrowser(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "views/index.html"))
            {
                Dock = DockStyle.Fill,
            };

            // browser.LoadingStateChanged += OnLoadingStateChanged;
            // browser.ConsoleMessage += OnBrowserConsoleMessage;
            browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
            this.Controls.Add(browser);
        }

        private void Browser_IsBrowserInitializedChanged(object sender, IsBrowserInitializedChangedEventArgs e)
        {
            // browser.ShowDevTools();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }
}

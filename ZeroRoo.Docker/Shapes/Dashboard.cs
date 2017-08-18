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

namespace ZeroRoo.Docker.Shapes
{
    public partial class Dashboard : Form
    {
        private readonly ChromiumWebBrowser browser;

        public Dashboard()
        {
            InitializeComponent();

            //this.Size = Screen.GetWorkingArea(this).Size;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.Location = new Point(0, 0);

            browser = new ChromiumWebBrowser("localhost:3000")
            {
                Dock = DockStyle.Fill,
            };
            var provider = Program.Runtime.Services.BuildServiceProvider();
            browser.RegisterAsyncJsObject("engine", provider.GetRequiredService<ZeroRooJsBradge>(), BindingOptions.DefaultBinder); //Standard object rego

            // browser.LoadingStateChanged += OnLoadingStateChanged;
            // browser.ConsoleMessage += OnBrowserConsoleMessage;
            browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
            this.Controls.Add(browser);
        }

        private void Browser_IsBrowserInitializedChanged(object sender, IsBrowserInitializedChangedEventArgs e)
        {
            browser.ShowDevTools();
        }
    }
}

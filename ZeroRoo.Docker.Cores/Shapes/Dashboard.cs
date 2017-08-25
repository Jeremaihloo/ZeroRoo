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
using ZeroRoo.Apps.Services;
using ZeroRoo.Docker.Cores.Services;
using System.Threading;

namespace ZeroRoo.Docker.Shapes
{
    internal class LifeSpanHandler : ILifeSpanHandler
    {
        private IServiceCollection services;
        public LifeSpanHandler(IServiceCollection services)
        {
            this.services = services;
        }

        public bool DoClose(IWebBrowser browserControl, IBrowser browser)
        {
            // throw new NotImplementedException();
            return true;
        }

        public void OnAfterCreated(IWebBrowser browserControl, IBrowser browser)
        {
            // throw new NotImplementedException();
        }

        public void OnBeforeClose(IWebBrowser browserControl, IBrowser browser)
        {
            // throw new NotImplementedException();
        }

        public bool OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            var provider = services.BuildServiceProvider();
            var server = provider.GetRequiredService<IAppServiceServer>();
           // new Thread(new ThreadStart(() =>
           //{
           //    server.SendMessage(new AppServiceMessage(typeof(Open).FullName, targetUrl));
           //})).Start();

            newBrowser = null;
            var chromiumWebBrowser = (ChromiumWebBrowser)browserControl;
            chromiumWebBrowser.Parent.Invoke(new Action(() =>
            {
                server.SendMessage(new AppServiceMessage("ZeroRoo.Docker.Cores.Services.Open", targetUrl));
            }));
            server.SendMessage(new AppServiceMessage("ZeroRoo.Docker.Cores.Services.Open", targetUrl));
            //chromiumWebBrowser.Load(targetUrl);
            frame.LoadUrl(targetUrl);
            return true;
        }

    }

    public partial class Dashboard : Form
    {
        private readonly ChromiumWebBrowser browser;

        public Dashboard(IServiceCollection services)
        {
            InitializeComponent();

            //this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(0, 0);
            this.WindowState = FormWindowState.Maximized;

            //var url = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "views/index.html");
            var url = "http://localhost:8080";

            browser = new ChromiumWebBrowser(url)
            {
                Dock = DockStyle.Fill,
            };

            // browser.LoadingStateChanged += OnLoadingStateChanged;
            // browser.ConsoleMessage += OnBrowserConsoleMessage;
            browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
            browser.LifeSpanHandler = new LifeSpanHandler(services);
            this.Controls.Add(browser);
        }

        private void Browser_IsBrowserInitializedChanged(object sender, IsBrowserInitializedChangedEventArgs e)
        {
            browser.ShowDevTools();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }
}

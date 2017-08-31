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
using System.Threading;

namespace ZeroRoo.Docker.Shapes
{
    internal class LifeSpanHandler : ILifeSpanHandler
    {
        private IAppServiceServer appServiceServer;
        public LifeSpanHandler(IAppServiceServer appServiceServer)
        {
            this.appServiceServer = appServiceServer;
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
            var msg = new AppServiceMessage("ZeroRoo.DefaultApp.Services.Open", new
                        {
                            Activity = new BaseActivity() { Title = "新网页" },
                            Target = targetUrl
                        });

            appServiceServer.SendMessage(msg);

            newBrowser = null;
            var chromiumWebBrowser = (ChromiumWebBrowser)browserControl;
            //chromiumWebBrowser.Load(targetUrl);
            //frame.LoadUrl(targetUrl);
            return true;
        }

    }

    public partial class Dashboard : Form
    {
        private readonly ChromiumWebBrowser browser;

        public Dashboard(IAppServiceServer appServiceServer)
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

            browser.BrowserSettings.WebSecurity = CefState.Disabled;
            browser.BrowserSettings.FileAccessFromFileUrls = CefState.Enabled;
            browser.BrowserSettings.UniversalAccessFromFileUrls = CefState.Enabled;
            browser.BrowserSettings.TextAreaResize = CefState.Disabled;

            // browser.LoadingStateChanged += OnLoadingStateChanged;
            // browser.ConsoleMessage += OnBrowserConsoleMessage;
            browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
            browser.LifeSpanHandler = new LifeSpanHandler(appServiceServer);
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

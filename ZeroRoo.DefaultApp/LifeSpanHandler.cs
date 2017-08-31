using CefSharp;
using CefSharp.WinForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;

namespace ZeroRoo.Docker.Cores
{
    public class LifeSpanHandler : ILifeSpanHandler
    {
        private IServiceProvider serviceProvider;
        public LifeSpanHandler(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
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
            var provider = serviceProvider;
            var server = provider.GetRequiredService<IAppServiceServer>();
            server.SendMessage(new AppServiceMessage("ZeroRoo.Docker.Cores.Services.Open", targetUrl));

            newBrowser = null;
            var chromiumWebBrowser = (ChromiumWebBrowser)browserControl;
            //chromiumWebBrowser.Parent.Invoke(new Action(() =>
            //{
            //    server.SendMessage(new AppServiceMessage("ZeroRoo.Docker.Cores.Services.Open", targetUrl));
            //}));
            server.SendMessage(new AppServiceMessage("ZeroRoo.Docker.Cores.Services.Open", targetUrl));
            //chromiumWebBrowser.Load(targetUrl);
            //frame.LoadUrl(targetUrl);
            return true;
        }

    }
}

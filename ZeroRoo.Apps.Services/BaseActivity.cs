using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Net;

namespace ZeroRoo.Apps.Services
{
    public class BaseActivity : IActivity
    {
        private string title;
        public virtual string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string routePattern;
        public virtual string RoutePattern
        {
            get { return routePattern; }
            set { routePattern = value; }
        }

        public virtual void OnView(HttpListenerRequest req, HttpListenerResponse res)
        {
            res.ContentType = "text/html; charset=utf-8";
        }

        public void WriteHtmlContent(HttpListenerResponse res, string content)
        {
            var cbytes = Encoding.UTF8.GetBytes(content);
            res.WriteContent(cbytes);
        }

        public void WriteViewContent(HttpListenerResponse res, string viewPath = "")
        {
            var content = Encoding.UTF8.GetBytes("This is BaseActivity !");

            if(File.Exists(viewPath))
            {
                content = File.ReadAllBytes(viewPath);
            }

            res.WriteContent(content);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.App
{
    public class FileDownloader
    {
        public FileDownloader()
        {
           
        }

        public string DownloadString(Uri uri)
        {
            if(uri.IsFile)
            {
                return File.ReadAllText(uri.OriginalString, Encoding.Default);
            }
            else
            {
                WebClient client = new WebClient();
                return client.DownloadString(uri);
            }
        }
    }
}

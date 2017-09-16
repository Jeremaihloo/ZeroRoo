using System;
using ZeroRoo.Apps.Services;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Linq;
namespace ZeroRoo.Apps.LaundryAgent
{
    public class LaundryAgent : IAppService
    {
        private string dataPath = "data/LaundryAgent";

        public void OnService(AppServiceRoute route, AppServiceMessage msg)
        {
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }
            if (msg.Data != null)
            {
                File.WriteAllText(dataPath + "/" + Utils.DateTimes.ConvertDateTimeInt(DateTime.Now) + ".json",
                                  JsonConvert.SerializeObject(msg.Data),
                                  Encoding.UTF8);
            }
            else
            {
                var data = File.ReadAllText(dataPath + "/" + getLatestFilePath(), Encoding.UTF8);
                msg.Data = JsonConvert.DeserializeObject(data);
            }
            route.SendMessage(msg);
        }

        private string getLatestFilePath()
        {
            var files = Directory.GetFiles(dataPath);
            return files.OrderByDescending(x => x).FirstOrDefault();
        }
    }
}

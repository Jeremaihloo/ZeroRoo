using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Docker.Navigation
{
    public class ActivityManager : IActivityManager
    {
        private List<IActivity> activedActivities = new List<IActivity>();

        public void Active(IActivity activity)
        {
            if(!activedActivities.Contains(activity))
            {
                activedActivities.Add(activity);
                activity.OnCreate();
            }
            else
            {
                activity.OnActive();
            }
        }
    }
}

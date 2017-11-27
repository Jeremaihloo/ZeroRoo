using System;
namespace ZeroRoo.Laundry15.Models
{
    public class User
    {
        public User()
        {
        }
        public string Phone { get; set; }
        public string PassWord { get; set; }

        public UserProfile Profile { get; set; }
    }
}

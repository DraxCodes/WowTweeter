using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace AutoTweetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Auth.SetUserCredentials("CONSUMER_KEY", "CONSUMER_SECRET", "ACCESS_TOKEN", "ACCESS_TOKEN_SECRET");
            var user = User.GetAuthenticatedUser();
            Debug.WriteLine(user.ScreenName);
        }
    }
}

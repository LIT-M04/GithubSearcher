using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GithubSearcher.API
{
    public static class GithubAPI
    {
        public static IEnumerable<GithubRepo> GetReposForUser(string username)
        {
            using (var webclient = new WebClient())
            {
                webclient.Headers.Add("User-Agent", "GITHUB SUX!!!!");
                string json = webclient.DownloadString("https://api.github.com/users/" + username + "/repos");
                return JsonConvert.DeserializeObject<IEnumerable<GithubRepo>>(json);
            }
        }
    }
}

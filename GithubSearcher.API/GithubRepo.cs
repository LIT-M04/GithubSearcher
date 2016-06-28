using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GithubSearcher.API
{
    public class GithubRepo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }

        [JsonProperty("stargazers_count")]
        public int Stars { get; set; }

        public GithubRepoOwner Owner { get; set; }
    }

    public class GithubRepoOwner
    {
        public string Login { get; set; }
        public int Id { get; set; }
    }
}

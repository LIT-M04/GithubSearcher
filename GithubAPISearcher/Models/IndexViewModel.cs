using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GithubSearcher.API;

namespace GithubAPISearcher.Models
{
    public class IndexViewModel
    {
        public IEnumerable<GithubRepo> Repos { get; set; } 
    }
}
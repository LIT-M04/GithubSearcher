using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GithubAPISearcher.Models;
using GithubSearcher.API;

namespace GithubAPISearcher.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string userName)
        {
            var viewModel = new IndexViewModel();
            if (!String.IsNullOrEmpty(userName))
            {
                viewModel.Repos = GithubAPI.GetReposForUser(userName);
            }
            return View(viewModel);
        }

    }
}

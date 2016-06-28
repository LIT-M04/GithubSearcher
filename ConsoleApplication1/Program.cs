using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GithubSearcher.API;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            var result = GithubAPI.GetReposForUser(username);
            foreach (var repo in result)
            {
                Console.WriteLine(repo.Name + " - " + repo.Stars + " - " + repo.Owner.Login);
            }

            Console.ReadKey(true);
        }
    }
}

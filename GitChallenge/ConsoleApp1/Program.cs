using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GitChallenge.Domain.RepositoryLanguages;
using GitChallenge.Domain.RepositoryLanguages.RepositorySpecification;
using GitChallenge.Infrastructure.Clients.GitHub;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IRepositoryLanguageExternalService github = new GitHubClient();

            var repos = await github.SearchRepositoriesAsync(new RepositorySearchCriteriaSpecification(5, SortByField.Stars,
                SortByDirection.Descending, new List<Language> {Language.CSharp, Language.Java}));

            Console.WriteLine("Hello World!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GitChallenge.Infrastructure.Clients.GitHub.Models;

namespace GitChallenge.Infrastructure.Clients.GitHub
{
    public class GitHubResources : VirtualResources
    {
        public GitHubResources()
        {
            ResourcesUrl.Add(typeof(SearchRepositories), SearchRepositoryUrl);
        }

        private const string SearchRepositoryUrl = "search/repositories";
    }
}

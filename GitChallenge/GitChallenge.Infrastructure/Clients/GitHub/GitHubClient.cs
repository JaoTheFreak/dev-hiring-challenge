using System;
using System.Collections.Generic;
using GitChallenge.Domain.RepositoryLanguages.RepositorySpecification;
using Octokit;
using System.Linq;
using System.Threading.Tasks;
using GitChallenge.Domain.RepositoryLanguages;

namespace GitChallenge.Infrastructure.Clients.GitHub
{
    public class GitHubClient : IRepositoryLanguageExternalService
    {
        private readonly Octokit.GitHubClient _client;

        public GitHubClient()
        {
            _client = new Octokit.GitHubClient(new ProductHeaderValue("GitChallenge"));
        }

        public async Task<IReadOnlyList<Domain.RepositoryLanguages.RepositoryLanguage>> SearchRepositoriesAsync(RepositorySearchCriteriaSpecification criteria)
        {
            SearchRepositoriesRequest searchCriteria;

            var foundedRepositories = new List<Domain.RepositoryLanguages.RepositoryLanguage>();

            if (criteria.Languages.Any())
            {
                var termLanguageCriteria = "q=language:";

                var finalTerm = criteria.Languages
                    .Select(languageInCriteria => (Octokit.Language) languageInCriteria)
                    .Aggregate(string.Empty, (current, language) => current + $"{termLanguageCriteria}{language} ");

                searchCriteria = new SearchRepositoriesRequest(finalTerm);
            }
            else
            {
                searchCriteria = new SearchRepositoriesRequest();
            }

            searchCriteria.SortField = (RepoSearchSort) criteria.SortBy;

            searchCriteria.Order = (SortDirection) criteria.SortByDirection;

            searchCriteria.PerPage = criteria.Take;

            if (criteria.Language != null)
            {
                searchCriteria.Language = (Octokit.Language) criteria.Language;
            }

            SearchRepositoryResult result;

            do
            {
                result = await _client.Search.SearchRepo(searchCriteria);

                foundedRepositories.AddRange(result.Items
                    .Select(i => 
                        new Domain.RepositoryLanguages.RepositoryLanguage(
                            Guid.NewGuid(), 
                            Guid.NewGuid(), 
                            i.Id, 
                            i.Name, 
                            i.FullName, 
                            i.HtmlUrl, 
                            i.Description, 
                            i.StargazersCount)));

            } while (criteria.Take > 0 && foundedRepositories.Count < criteria.Take || result.IncompleteResults);

            return foundedRepositories;
        }
    }
}

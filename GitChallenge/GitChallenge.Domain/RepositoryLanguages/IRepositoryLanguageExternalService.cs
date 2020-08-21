using GitChallenge.Domain.RepositoryLanguages.RepositorySpecification;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitChallenge.Domain.RepositoryLanguages
{
    public interface IRepositoryLanguageExternalService
    {
        Task<IReadOnlyList<RepositoryLanguage>> SearchRepositoriesAsync(
            RepositorySearchCriteriaSpecification criteria);
    }
}

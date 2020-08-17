using GitChallenge.Domain.RepositoryLanguages;
using System;
using System.Collections.Generic;

namespace GitChallenge.Domain.ProgrammingLanguages
{
    public class ProgrammingLanguage
    {
        public ProgrammingLanguage(string name, IReadOnlyList<RepositoryLanguage> repositoryLanguages)
        {
            Id = Guid.NewGuid();

            Name = name;

            RepositoryLanguages = repositoryLanguages;
        }

        //Empty ctor for EntityFramework
        protected ProgrammingLanguage() { }

        public Guid Id { get; }

        public string Name { get; }

        public virtual IReadOnlyList<RepositoryLanguage> RepositoryLanguages { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using GitChallenge.Domain.OwnerRepositoryLanguages;
using GitChallenge.Domain.ProgrammingLanguages;

namespace GitChallenge.Domain.RepositoryLanguages
{
    public class RepositoryLanguage
    {
        public RepositoryLanguage(Guid ownerRepositoryId, Guid programmingLanguageId, long repositoryExternalId, string name, string fullName, string repositoryAddress,
            string description, int stargazers)
        {
            Id = Guid.NewGuid();

            OwnerRepositoryId = ownerRepositoryId;

            ProgrammingLanguageId = programmingLanguageId;

            RepositoryExternalId = repositoryExternalId;

            Name = name;

            FullName = fullName;

            RepositoryAddress = repositoryAddress;

            Description = description;

            Stargazers = stargazers;

            RegisteredAt = DateTime.UtcNow;
        }

        //Empty ctor for EntityFramework
        protected RepositoryLanguage() {}

        public Guid Id { get; }

        public Guid ProgrammingLanguageId { get; }

        public Guid OwnerRepositoryId { get; }

        public long RepositoryExternalId { get; }

        public string Name { get; }

        public string FullName { get; }

        public string RepositoryAddress { get; }

        public string Description { get; }

        public int Stargazers { get; }

        public DateTime RegisteredAt { get; }

        public virtual OwnerRepositoryLanguage OwnerRepositoryLanguage { get; }

        public virtual ProgrammingLanguage ProgrammingLanguage  { get;}
    }
}

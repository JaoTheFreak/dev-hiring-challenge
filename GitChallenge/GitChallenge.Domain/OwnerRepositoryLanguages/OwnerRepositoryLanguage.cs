using System;
using System.Collections.Generic;
using System.Text;

namespace GitChallenge.Domain.OwnerRepositoryLanguages
{
    public class OwnerRepositoryLanguage
    {
        public OwnerRepositoryLanguage(long ownerExternalId, string login,  string profileAddress, string profileIcon)
        {
            Id = Guid.NewGuid();
            
            OwnerExternalId = ownerExternalId;

            Login = login;

            ProfileAddress = profileAddress;

            ProfileIcon = profileIcon;
        }

        //Empty ctor for EntityFramework
        protected OwnerRepositoryLanguage() {}
        
        public Guid Id { get; }

        public long OwnerExternalId { get; }

        public string Login { get; }

        public string ProfileAddress { get; }

        public string ProfileIcon { get; }
    }
}

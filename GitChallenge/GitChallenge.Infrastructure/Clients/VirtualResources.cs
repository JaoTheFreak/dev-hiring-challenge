using System;
using System.Collections.Generic;

namespace GitChallenge.Infrastructure.Clients
{
    public abstract class VirtualResources
    {
        protected Dictionary<Type, string> ResourcesUrl = new Dictionary<Type, string>();
        public string GetResource<T>()
        {
            return ResourcesUrl[typeof(T)];
        }
    }
}

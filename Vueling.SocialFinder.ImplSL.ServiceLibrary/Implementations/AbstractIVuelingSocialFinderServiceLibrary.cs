using System;
using System.Collections.Generic;
using Vueling.SocialFinder.Contracts.ServiceLibrarySL.Commons;
using Vueling.SocialFinder.Contracts.ServiceLibrarySL.DTO;
using Vueling.SocialFinder.ContractsSL.ServiceLibrary;

namespace Vueling.SocialFinder.ImplSL.ServiceLibrary.Implementations
{
    public abstract class AbstractIVuelingSocialFinderServiceLibrary : IVuelingSocialFinderServiceLibrary
    {
        public virtual IEnumerable<PostDTO> GetLatestPost(int dayOffset, string query)
        {
            string token = this.ConnectAndGetToken();
            return this.getLatestPostsCallingAPI(token, dayOffset,query);
        }

        public abstract string ConnectAndGetToken();

        protected abstract IEnumerable<PostDTO> getLatestPostsCallingAPI(string token, int dayOffSet,string query);

        public abstract SocialMediaProvider ProviderName { get;}

    }
}

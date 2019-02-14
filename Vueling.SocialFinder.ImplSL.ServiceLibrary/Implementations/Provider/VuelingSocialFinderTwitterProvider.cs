using System;
using System.Collections.Generic;
using Vueling.SocialFinder.Contracts.ServiceLibrarySL.Commons;
using Vueling.SocialFinder.Contracts.ServiceLibrarySL.DTO;

namespace Vueling.SocialFinder.ImplSL.ServiceLibrary.Implementations.Provider
{
    public class VuelingSocialFinderTwitterProvider : AbstractIVuelingSocialFinderServiceLibrary
    {
        public override string ConnectAndGetToken()
        {
            return "";
        }

        public override SocialMediaProvider ProviderName
        {
            get
            {
                return SocialMediaProvider.Tweeter;
            }
        }


        protected override IEnumerable<PostDTO> getLatestPostsCallingAPI(string token, int dayOffSet, string query)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Provider" + this.ProviderName;
        }
    }
}

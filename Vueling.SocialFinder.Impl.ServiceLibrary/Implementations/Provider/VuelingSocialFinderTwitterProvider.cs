using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.SocialFinder.Contracts.ServiceLibrary.Commons;
using Vueling.SocialFinder.Contracts.ServiceLibrary.DTO;

namespace Vueling.SocialFinder.Impl.ServiceLibrary.Implementations.Provider
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

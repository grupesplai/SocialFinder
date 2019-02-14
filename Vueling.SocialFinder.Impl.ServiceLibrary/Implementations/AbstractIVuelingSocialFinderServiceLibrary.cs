using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.SocialFinder.Contracts.ServiceLibrary;
using Vueling.SocialFinder.Contracts.ServiceLibrary.Commons;
using Vueling.SocialFinder.Contracts.ServiceLibrary.DTO;

namespace Vueling.SocialFinder.Impl.ServiceLibrary.Implementations
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

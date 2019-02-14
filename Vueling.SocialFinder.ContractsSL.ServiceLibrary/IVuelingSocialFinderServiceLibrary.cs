using System.Collections.Generic;
using Vueling.SocialFinder.Contracts.ServiceLibrarySL.DTO;

namespace Vueling.SocialFinder.ContractsSL.ServiceLibrary
{
    public interface IVuelingSocialFinderServiceLibrary
    {
        IEnumerable<PostDTO> GetLatestPost(int dayOffset, string query);
    }
}

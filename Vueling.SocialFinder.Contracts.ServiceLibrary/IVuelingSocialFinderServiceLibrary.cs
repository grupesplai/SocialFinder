using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vueling.SocialFinder.Contracts.ServiceLibrary.DTO;

namespace Vueling.SocialFinder.Contracts.ServiceLibrary
{
    public interface IVuelingSocialFinderServiceLibrary
    {
        IEnumerable<PostDTO> GetLatestPost(int dayOffset, string query);
    }
}

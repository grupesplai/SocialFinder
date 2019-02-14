
namespace Vueling.SocialFinder.Process.ContractsSL.ServiceLibrary
{
    public interface IVuelingSocialFinderProcess
    {
        void ProcessAllProvidersPosts();

        void ProcessProviderPosts(string provider);
    }
}
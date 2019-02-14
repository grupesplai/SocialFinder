
namespace Vueling.SocialFinder.Process.Contracts.ServiceLibrary
{
    public interface IVuelingSocialFinderProcess
    {
        void ProcessAllProvidersPosts();

        void ProcessProviderPosts(string provider);
    }
}
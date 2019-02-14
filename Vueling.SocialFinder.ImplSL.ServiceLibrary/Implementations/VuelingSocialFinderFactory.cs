using System;
using System.Collections;
using System.Collections.Generic;
using Vueling.SocialFinder.Contracts.ServiceLibrarySL.Commons;
using Vueling.SocialFinder.ImplSL.ServiceLibrary.Implementations.Provider;

namespace Vueling.SocialFinder.ImplSL.ServiceLibrary.Implementations
{
    public class VuelingSocialFinderFactory
    {
        private static IDictionary<SocialMediaProvider, AbstractIVuelingSocialFinderServiceLibrary> _provider;

        public static IDictionary<SocialMediaProvider, AbstractIVuelingSocialFinderServiceLibrary> getProvider()
        {
            if (_provider == null)
            {
                _provider = new Dictionary<SocialMediaProvider, AbstractIVuelingSocialFinderServiceLibrary>();

                VuelingSocialFinderTwitterProvider twitterProvider = new VuelingSocialFinderTwitterProvider();
                _provider.Add(twitterProvider.ProviderName, twitterProvider);
            }
            return _provider;
        }

        public static AbstractIVuelingSocialFinderServiceLibrary GetProvider(SocialMediaProvider provider)
        {
            if (getProvider().ContainsKey(provider))
                return getProvider()[provider];
            throw new Exception("Provider for "+provider.ToString()+ " not found");
        }

        public static IEnumerable<AbstractIVuelingSocialFinderServiceLibrary> GetAllProvider()
        {
            return getProvider().Values;
        }
    }
}

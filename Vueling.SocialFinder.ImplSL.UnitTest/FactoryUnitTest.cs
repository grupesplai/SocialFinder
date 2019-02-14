using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Vueling.SocialFinder.Contracts.ServiceLibrarySL.Commons;
using Vueling.SocialFinder.ContractsSL.ServiceLibrary;
using Vueling.SocialFinder.ImplSL.ServiceLibrary.Implementations;
using Vueling.SocialFinder.ImplSL.ServiceLibrary.Implementations.Provider;

namespace Vueling.SocialFinder.ImplSL.UnitTest
{
    [TestClass]
    public class FactoryUnitTest
    {
        [TestMethod]
        public void GivingASocialNetworkName_GetTheClassThatImplement()
        {
            IVuelingSocialFinderServiceLibrary twitterProvider = VuelingSocialFinderFactory.GetProvider(SocialMediaProvider.Tweeter);
            Assert.IsNotNull(twitterProvider);
            Assert.AreEqual(true, twitterProvider is VuelingSocialFinderTwitterProvider);
        }

        [TestMethod]
        public void GivingAllProviders_CuntList()
        {
            IEnumerable<IVuelingSocialFinderServiceLibrary> providers = VuelingSocialFinderFactory.GetAllProvider();

            Assert.AreEqual(true, new List<IVuelingSocialFinderServiceLibrary>(providers).Count >= 1);
        }
    }
}

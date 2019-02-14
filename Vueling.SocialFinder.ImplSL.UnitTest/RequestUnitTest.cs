using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vueling.SocialFinder.ContractsSL.ServiceLibrary;
using Vueling.SocialFinder.ImplSL.ServiceLibrary.Helper;

namespace Vueling.SocialFinder.ImplSL.UnitTest
{
    [TestClass]
    public class RequestUnitTest
    {
        [TestMethod]
        public void GivinMehotdTypeAndHeader()
        {
            string url = "https://api.twitter.com/oauth2/token";

            IList<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>("Authorization", "Basic eXZMeFpwU25SMlpwZmU3UmxCaFlmR3ZWejpEaFVoMzNUMEY5RWQycEczcFAxcVptMjFQZGg4WUtTWTlPU2FxYThvTzVYbmp6dmh5Ug=="));
            headers.Add(new KeyValuePair<string, string>("Content-Type", "application/x-www-form-urlencoded;charset=UTF-8."));

            var postValues = new Dictionary<string, string> { { "grant_type", "client_credentials" } };
            string result = Task.Run(() => HttpHelper.HttpClientRequestAsync(url, Method.POST, headers, postValues)).Result;

            Assert.AreEqual(true, result.Contains("access_token"));
        }

        [TestMethod]
        public void GivingAJsonString_GetADynamic()
        {
            string json = @"{""name"":""TestMethod""}";

            dynamic data = HttpHelper.GetObjFromString(json);

            Assert.AreEqual(data.name, "TestMethod");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Helpers;
using Vueling.SocialFinder.ContractsSL.ServiceLibrary;

namespace Vueling.SocialFinder.ImplSL.ServiceLibrary.Helper
{
    public class HttpHelper
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> HttpClientRequestAsync(string uri, Method method, IList<KeyValuePair<string, string>> headers, IDictionary<string, string> postValues = null)
        {
            foreach (var header in headers)
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation(header.Key, header.Value);
            }

            HttpResponseMessage response = null;

            switch (method)
            {
                case Method.POST:
                    var body = new FormUrlEncodedContent(postValues);
                    response = await client.PostAsync(uri, body);
                    break;
                case Method.GET:
                    response = await client.GetAsync(uri);
                    break;
                default:
                    break;
            }

            var jsResponse = await response.Content.ReadAsStringAsync();

            return jsResponse;
        }

        public static dynamic GetObjFromString(string json)
        {
            dynamic data = Json.Decode(json);
            return data;
        }
    }
}

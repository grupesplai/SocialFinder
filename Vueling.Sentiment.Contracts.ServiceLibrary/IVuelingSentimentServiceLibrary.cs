using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Sentiment.Contracts.ServiceLibrary
{
    public interface IVuelingSentimentServiceLibrary
    {
        double CalculateSentiment(string text);
    }
}

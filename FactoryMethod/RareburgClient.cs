using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal class RareburgClient : IFeedDataClient
    {
        public List<Article> GetAllArticles()
        {
            return new List<Article>();
        }
    }
}
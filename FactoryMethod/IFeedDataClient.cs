using System.Collections.Generic;

namespace FactoryMethod
{
    public interface IFeedDataClient
    {
        List<Article> GetAllArticles();
    }
}
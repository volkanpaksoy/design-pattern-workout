﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AppConfigFeedServiceSettings : IFeedServiceSettings
    {
        public string Title
        {
            get { return ConfigurationManager.AppSettings["FeedService.Title"]; }
        }

        public string Description
        {
            get { return ConfigurationManager.AppSettings["FeedService.Description"]; }
        }

        public string BaseUri
        {
            get { return ConfigurationManager.AppSettings["FeedService.BaseUri"]; }
        }

        public string Category
        {
            get { return ConfigurationManager.AppSettings["FeedService.Category"]; }
        }

        public string ArticleUrl
        {
            get { return ConfigurationManager.AppSettings["FeedService.ArticleUrl"]; }
        }

        public string UserUrl
        {
            get { return ConfigurationManager.AppSettings["FeedService.UserUrl"]; }
        }
    }
}

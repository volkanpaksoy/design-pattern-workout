﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IFeedSettings
    {
        string FeedFormat { get; }
        string FeedUrl { get; }
    }
}

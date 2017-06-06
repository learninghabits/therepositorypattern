﻿using System.Data.Entity;

namespace repo_pattern.DB
{
    public class TopicsDataContext : DbContext, ITopicsDataContext
    {
        public IDbSet<Topic> Topics { get; set; }
        public IDbSet<Tutorial> Tutorials { get; set; }
    }
}
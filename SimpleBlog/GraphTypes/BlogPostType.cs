using GraphQL.Types;
using SimpleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.GraphTypes
{
    public class BlogPostType:ObjectGraphType<BlogPost>
    {
        public BlogPostType()
        {
            Name = "BlogPost";
            Description = "BlogPost Type";
            Field(_ => _.Id);
            Field(_ => _.Title);
            Field(_ => _.Content);
     
        }
    }
}

using GraphQL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.Queries
{
    public class GraphQLBlogSchema:GraphQL.Types.Schema,GraphQL.Types.ISchema
    {
        public GraphQLBlogSchema(IDependencyResolver resolver):base(resolver)
        {
            Query = resolver.Resolve<AuthorQuery>();
        }
    }
}

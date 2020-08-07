using GraphQL.Types;
using SimpleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.GraphTypes
{
    public class AuthorType:ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Name = "Author";
            Description = "Author Type";
            Field(_ => _.Id);
            Field(_ => _.FirstName);
            Field(_ => _.LastName);
        }
    }
}

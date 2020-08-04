using GraphQL.Types;
using SimpleTalk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTalk.Types
{
    public class CommentType : ObjectGraphType<Comment>
    {
        public CommentType()
        {
            Field(x => x.Count);
            Field(x => x.Description);
            Field(x => x.Url);
        }
    }
}

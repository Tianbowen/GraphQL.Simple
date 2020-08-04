using GraphQL.Types;
using SimpleTalk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTalk.Types
{

    public class SocialNetworkType : ObjectGraphType<SocialNetwork>
    {
        public SocialNetworkType()
        {
            Field(x => x.NickName);
            Field<EnumerationGraphType<SNType>>("type");
            Field(x => x.Url);
            Field<AuthorType>("author");
        }
    }

}

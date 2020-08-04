using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using SimpleTalk.Entities;

namespace SimpleTalk.Types
{

    public class SNTypeType : EnumerationGraphType<SNType>
    {
        public SNTypeType()
        {
            Name = "SNTypeType";
        }
    }
}

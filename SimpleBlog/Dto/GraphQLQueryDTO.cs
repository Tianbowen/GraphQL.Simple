using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.Dto
{
    public class GraphQLQueryDTO
    {
        public string OperationName { get; set; }

        public string NameQuery { get; set; }

        public string Query { get; set; }

        public string Variables { get; set; }
    }
}

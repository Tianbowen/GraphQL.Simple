using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using SimpleTalk.Queries;
using SimpleTalk.Services;
using SimpleTalk.Types;

namespace SimpleTalk.Controllers
{
    [Route(Startup.GraphQLPath)]
    public class GraphQLController : Controller
    {
        readonly BlogService blogService;

        public GraphQLController(BlogService blogService)
        {
            this.blogService = blogService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQlQuery query)
        {
            var schema = new Schema { Query = new AuthorQuery(blogService) };

            var result = await new DocumentExecuter().ExecuteAsync(x =>
              {
                  x.Schema = schema;
                  x.Query = query.Query;
                  //x.Inputs = query.Variables;
              });
            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result.Data);
        }

        // 调用示例
        //query GetBlogData($id: Int!)
        //{
        //    author(id: $id) {
        //        id
        //        name
        //    }
        //    posts(id: $id) {
        //        author {
        //            bio
        //        }
        //        categories
        //        comments {
        //            description
        //            count
        //          url
        //        }
        //    }
        //    socials(id: $id) {
        //        nickName
        //        type
        //    }
        //}

        //{
        //    id:1
        //}

    }
}

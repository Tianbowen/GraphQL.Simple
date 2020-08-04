using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphiQl;
using GraphQL;
//using GraphQL.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SimpleTalk.Services;
using SimpleTalk.Types;

namespace SimpleTalk
{
    public class Startup
    {
        public const string GraphQLPath = "/graphql";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {      
            services.AddScoped<IDocumentExecuter, DocumentExecuter>();

            services.AddScoped<BlogService>();
            services.AddScoped<AuthorType>();
            services.AddScoped<CommentType>();
            services.AddScoped<PostType>();
            services.AddScoped<RatingType>();
            services.AddScoped<SNTypeType>();
            services.AddScoped<SocialNetworkType>();

            services.AddControllers();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseGraphiQl(GraphQLPath);

            app.UseRouting();
         
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace aspnetcoreapp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
            {
                var  message = "<h1>So how does it feel...</h1>";
                message += "<p>To be running a .Net app on a Mac?</p>";
                return context.Response.WriteAsync(message);
            });
        }
    }
}

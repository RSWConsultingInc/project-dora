
using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
[assembly: OwinStartupAttribute(typeof(ProjectDoraWeb.Startup))]

namespace ProjectDoraWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            ConfigureAuth(app);

            
        }
    }
}

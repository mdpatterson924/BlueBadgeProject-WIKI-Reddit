using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wikipedia_Reddit.WebMVC.Startup))]
namespace Wikipedia_Reddit.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

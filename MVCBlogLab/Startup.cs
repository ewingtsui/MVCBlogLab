using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBlogLab.Startup))]
namespace MVCBlogLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

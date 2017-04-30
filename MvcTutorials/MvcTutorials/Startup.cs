using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTutorials.Startup))]
namespace MvcTutorials
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TSTuring2015.MVC5Web.Startup))]
namespace TSTuring2015.MVC5Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

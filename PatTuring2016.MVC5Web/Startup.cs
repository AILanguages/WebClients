using Microsoft.Owin;
using Owin;
using PatTuring2016.MVC5Web;

[assembly: OwinStartup(typeof(Startup))]
namespace PatTuring2016.MVC5Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

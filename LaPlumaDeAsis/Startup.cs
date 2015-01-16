using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LaPlumaDeAsis.Startup))]
namespace LaPlumaDeAsis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

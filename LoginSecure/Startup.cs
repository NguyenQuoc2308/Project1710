using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginSecure.Startup))]
namespace LoginSecure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

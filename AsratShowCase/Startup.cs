using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AsratShowCase.Startup))]
namespace AsratShowCase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

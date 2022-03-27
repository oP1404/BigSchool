using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911065208_CaoVanHau.Startup))]
namespace _1911065208_CaoVanHau
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

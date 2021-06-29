using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Buoi_3.Startup))]
namespace Buoi_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaA.Startup))]
namespace SistemaA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

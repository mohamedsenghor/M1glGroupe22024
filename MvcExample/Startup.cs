using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcExample.Startup))]
namespace MvcExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

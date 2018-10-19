using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ObuvkaStore.Startup))]
namespace ObuvkaStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

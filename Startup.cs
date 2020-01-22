using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrubakerMIS4200.Startup))]
namespace BrubakerMIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

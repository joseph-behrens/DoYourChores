using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoYourChores.Startup))]
namespace DoYourChores
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyNaggingMom.Startup))]
namespace MyNaggingMom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

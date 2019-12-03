using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TPVersao4.Startup))]
namespace TPVersao4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

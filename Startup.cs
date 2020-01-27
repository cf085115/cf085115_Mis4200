using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cf085115_Mis4200.Startup))]
namespace cf085115_Mis4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserReg.Startup))]
namespace UserReg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

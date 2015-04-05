using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoEdu.Startup))]
namespace AutoEdu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

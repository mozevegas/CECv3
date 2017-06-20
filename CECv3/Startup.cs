using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CECv3.Startup))]
namespace CECv3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

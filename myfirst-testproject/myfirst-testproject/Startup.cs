using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myfirst_testproject.Startup))]
namespace myfirst_testproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

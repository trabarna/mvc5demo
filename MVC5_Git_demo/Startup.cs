using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_Git_demo.Startup))]
namespace MVC5_Git_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(identiryexample.Startup))]
namespace identiryexample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

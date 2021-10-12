using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prototype_four.Startup))]
namespace prototype_four
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

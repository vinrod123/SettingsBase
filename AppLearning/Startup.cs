using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppLearning.Startup))]
namespace AppLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

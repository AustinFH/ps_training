using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSTrainingTesterday.Startup))]
namespace PSTrainingTesterday
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

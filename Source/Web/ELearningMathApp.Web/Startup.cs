using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ELearningMathApp.Web.Startup))]
namespace ELearningMathApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

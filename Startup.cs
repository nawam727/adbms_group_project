using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(adbms_group_project.Startup))]
namespace adbms_group_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

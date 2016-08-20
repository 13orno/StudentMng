using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentMng.Startup))]
namespace StudentMng
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSSAJobBoard_w_Login.Startup))]
namespace MSSAJobBoard_w_Login
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

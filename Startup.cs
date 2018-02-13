using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bankacademy.Startup))]
namespace bankacademy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

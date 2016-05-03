using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebhookService.Startup))]
namespace WebhookService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

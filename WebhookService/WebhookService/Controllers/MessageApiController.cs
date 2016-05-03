using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.WebHooks;
using System.Threading.Tasks;

namespace WebhookService.Controllers
{
    [Authorize]
    public class MessageApiController : ApiController
    {

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

       
        public async Task Post([FromBody]string message)
        {
            await this.NotifyAsync("added", new { message = message });
        }



        public async Task Delete(int id)
        {
            string message = String.Empty;

            await this.NotifyAsync("deleted", new { message = message });
        }
    }
}

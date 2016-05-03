using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.WebHooks;

namespace WebhookService.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {

        [HttpPost]
        public async Task<ActionResult> Create(FormCollection collection)
        {

            string message = collection.Get("message");

            //This comes from extension methods from package Microsoft.AspNet.WebHooks.Custom.Mvc
            await this.NotifyAsync("added", new { message = message });

            return new EmptyResult();
          
        }

       
        [HttpPost]
        public async Task<ActionResult> Delete(int id, FormCollection collection)
        {
           
            string message = String.Empty;

            //This comes from extension methods from package Microsoft.AspNet.WebHooks.Custom.Mvc
            await this.NotifyAsync("deleted", new { message = message });

            return new EmptyResult();
           
        }
    }
}

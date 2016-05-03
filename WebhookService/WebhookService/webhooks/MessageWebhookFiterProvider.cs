using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;


namespace WebhookService.webhooks
{
    public class MessageWebhookFiterProvider : IWebHookFilterProvider
    {
        public Task<Collection<WebHookFilter>> GetFiltersAsync()
        {
            return Task.FromResult(this.filters);
        }

        private readonly Collection<WebHookFilter> filters = new Collection<WebHookFilter>
        {
            new WebHookFilter { Name = "added", Description = "Message was added." },

            new WebHookFilter { Name = "deleted", Description = "Message was deleted." },
        };     
    }
}




using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;

namespace WebhookService.webhooks
{
    public class MessageWebhookHandler : WebHookHandler
    {
        public MessageWebhookHandler()
        {
            this.Receiver = CustomWebHookReceiver.ReceiverName;
        }

        public override Task ExecuteAsync(string generator, WebHookHandlerContext context)
        {
            CustomNotifications data = context.GetDataOrDefault<CustomNotifications>();

            foreach (IDictionary<string, object> notification in data.Notifications)
            {
                var action = notification["Action"];

                var message= notification["message"];
                
                System.Diagnostics.Debug.Write($"Action: {action} Message: {message}");
            }

            return Task.FromResult(true);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.WebHooks;
using Microsoft.AspNet.WebHooks.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WebhookService.webhooks
{
    //register this class with the DI container as IWebHookSender implementation
    //to override and preprocess the outgoing data
    public class MesssgeWebHookSender : DataflowWebHookSender
    {
        public MesssgeWebHookSender(ILogger logger)
            : base(logger)
        {
        }

        protected override HttpRequestMessage CreateWebHookRequest(WebHookWorkItem workItem)
        {
            return base.CreateWebHookRequest(workItem);
        }


        protected override JObject CreateWebHookRequestBody(WebHookWorkItem workItem)
        {
            return base.CreateWebHookRequestBody(workItem);
        }


        protected override void SignWebHookRequest(WebHookWorkItem workItem, HttpRequestMessage request, JObject body)
        {
            base.SignWebHookRequest(workItem, request, body);
        }
    }
}
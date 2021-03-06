﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebhookService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            //Webhook url format for custom webhooks
            //http(s)://<host>/api/webhooks/incoming/custom
            config.InitializeCustomWebHooks();

            //defaults to in memory storage
            //config.InitializeCustomWebHooksAzureStorage();
            //config.InitializeCustomWebHooksSqlStorage();

            config.InitializeCustomWebHooksApis();


            //////////////////////
            // Create custom WebHookManager with custom retry policy
            //ILogger logger = config.DependencyResolver.GetLogger();
            //IWebHookStore store = config.DependencyResolver.GetStore();
            //IWebHookManager manager = new WebHookManager(store, logger, new TimeSpan[] { }, null);


            //// Register WebHookManager with Autofac 
            //ContainerBuilder builder = new ContainerBuilder();
            //builder.RegisterInstance(manager).As<IWebHookManager>().SingleInstance();

            //// Register MVC and Web API controllers with Autofac
            //Assembly currentAssembly = Assembly.GetExecutingAssembly();
            //builder.RegisterApiControllers(currentAssembly);
            //builder.RegisterControllers(currentAssembly);

            //// Build the Autofac container and set it as the dependency resolver for both MVC and Web API
            //IContainer container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            //////////////////////

            config.InitializeReceiveCustomWebHooks();


        }
    }
}

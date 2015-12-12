﻿using Autofac;
using Autofac.Integration.Mvc;
using FoodyDomain.Model;
using FoodyRespository.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foody.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<MenuResponsitory>().As<FoodyDomain.IResponsitory<MenuEntity>>();
            var container = builder.Build();
            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
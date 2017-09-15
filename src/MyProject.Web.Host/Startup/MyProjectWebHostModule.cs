﻿using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProject.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace MyProject.Web.Host.Startup
{
    [DependsOn(
       typeof(MyProjectWebCoreModule))]
    public class MyProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProjectWebHostModule).GetAssembly());
        }
    }
}

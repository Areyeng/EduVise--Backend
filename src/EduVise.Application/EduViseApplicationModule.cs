﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EduVise.Authorization;

namespace EduVise
{
    [DependsOn(
        typeof(EduViseCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EduViseApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EduViseAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EduViseApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

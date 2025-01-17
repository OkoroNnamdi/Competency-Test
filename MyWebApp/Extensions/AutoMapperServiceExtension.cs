﻿using RelationDataBaseSystem.Infrastructure;

namespace MyWebApp.Extensions
{
    public static  class AutoMapperServiceExtension
    {

        public static void ConfigureAutoMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapInitializer));
        }
    }
}

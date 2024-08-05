using RelationDataBaseSystem.Repository;

namespace MyWebApp.Extensions
{
    public static  class DIServiceExtension
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            

        }
    }
}

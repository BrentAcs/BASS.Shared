using Bass.Shared.Infrastructure.Storage;

namespace Bass.Shared.Extensions;

public static class MongoDbServiceCollectionExtensions
{
   public static IServiceCollection AddBassMongoCommon(this IServiceCollection services, IConfiguration configuration)
   {
      services
         .Configure<MongoDbSettings>(configuration.GetSection("MongoDb"))
         .AddSingleton<IMongoDbSettings>(serviceProvider =>
            serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value)
         .AddSingleton<IMongoContext, MongoContext>()
         ;

      return services;
   }
}
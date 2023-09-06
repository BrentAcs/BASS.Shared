using Bass.Shared.Infrastructure.Storage;

namespace Bass.Shared.Extensions;

public static class MongoRepositoryExtensions
{
   public static IEnumerable<string?> GetCollectionNames(this IEnumerable<IMongoRepository> repos) =>
      repos.Select(r => r.CollectionName);
   
   public static Task[] InitializeAllIndexesAsync(this IEnumerable<IMongoRepository> repos) =>
      repos.Select(repo => repo.InitializeIndexesAsync()).ToArray();
   
   public static Task[] SeedAllDataAsync(this IEnumerable<IMongoRepository> repos) =>
      repos.Select(repo => repo.SeedDataAsync()).ToArray();
}

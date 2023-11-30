namespace Bass.Shared.Extensions;

public static class NewtonsoftJsonExtensions
{
   public static string? ToJson(this object? obj, JsonSerializerSettings? settings = null)
   {
      if (obj == null)
         return null;

      settings ??= new JsonSerializerSettings();

      return JsonConvert.SerializeObject(obj, settings);
   }

   public static void ToJsonFile(this object obj, string filename, JsonSerializerSettings? settings = null)
   {
      settings ??= new JsonSerializerSettings
      {
         DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
         Formatting = Formatting.Indented
      };

      File.WriteAllText(filename, obj.ToJson(settings));
   }

   public static T? FromJson<T>(this string json, JsonSerializerSettings? settings = null)
   {
      settings ??= new JsonSerializerSettings();
      settings.TypeNameHandling = TypeNameHandling.All;
      return JsonConvert.DeserializeObject<T>(json, settings);
   }

   public static T? FromJsonFile<T>(this string filename, JsonSerializerSettings? settings = null)
   {
      settings ??= new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate };
      return File.ReadAllText(filename).FromJson<T>(settings);
   }
}

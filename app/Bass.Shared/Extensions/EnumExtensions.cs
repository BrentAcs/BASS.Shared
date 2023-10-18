using Bass.Shared.Utilities;

namespace Bass.Shared.Extensions;

public static class EnumExtensions
{
   public static T? GetAttributeOfType<T>(this Enum enumVal) where T : Attribute
   {
      var type = enumVal.GetType();
      var memInfo = type.GetMember(enumVal.ToString());
      var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
      return (attributes.Length > 0) ? (T)attributes[0] : null;
   }

   public static T GetRandomValue<T>(this IRng rng) //where T : Enum
   {
      Enum.GetValues(typeof(T));

      throw new NotImplementedException();
   }
}

public enum Test
{
   A,
   B
}

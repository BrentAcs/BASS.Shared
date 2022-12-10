namespace Bass.Shared.Geometry;

public record Ellipsoid(int X, int Y, int Z)
{
   public int X { get; set; }
   public int Y { get; set; }
   public int Z { get; set; }

   public static readonly Ellipsoid Empty = new(default, default, default);  
}

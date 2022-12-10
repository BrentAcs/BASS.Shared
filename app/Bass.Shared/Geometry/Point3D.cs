namespace Bass.Shared.Geometry;

public record Point3d(int X, int Y, int Z)
{
   public int X { get; set; }
   public int Y { get; set; }
   public int Z { get; set; }

   public static readonly Point3d Empty = new(default, default, default);  
}

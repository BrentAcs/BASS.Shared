namespace Bass.Shared.Geometry;

public record Point3dF(double X, double Y, double Z)
{
   public double X { get; set; }
   public double Y { get; set; }
   public double Z { get; set; }

   public static readonly Point3dF Empty = new(default, default, default);  
}

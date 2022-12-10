namespace Bass.Shared.Geometry;

public record EllipsoidF(double X, double Y, double Z)
{
   public double X { get; set; }
   public double Y { get; set; }
   public double Z { get; set; }

   public static readonly EllipsoidF Empty = new(default, default, default);  
}

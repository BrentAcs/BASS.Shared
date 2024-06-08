using Bass.Shared.Geometry;

namespace Bass.Shared.Utilities;

public static class Calculate
{
   public static double Distance(this Point3dF pointFrom, Point3dF pointTo) =>
      Distance(pointFrom.X, pointFrom.Y, pointFrom.Z, pointTo.X, pointTo.Y, pointTo.Z);

   public static double Distance(double x1, double y1, double z1, double x2, double y2, double z2) =>
      Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
}

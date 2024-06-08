# BASS.Shared
Brent Acs Software Solutions Shared libs
                                                

MinMax<T>
                                                               
ValueRequest<T>
- AbsoluteValue
- SubsetSelection: IEnumerable<T>
- MinMax<T>
- Value                                      

NumberRequest<T> : ValueRequest<Int32>

Int32Request : NumberRequest<Int32>
Int64Request : NumberRequest<Int64>
FloatRequest : NumberRequest<float>
doubleRequest : NumberRequest<diameter>


using Bass.Shared.Geometry;

public static class Calculate
{
   public static double Distance(this Point3dF pointFrom, Point3dF pointTo) =>
      Distance(pointFrom.X, pointFrom.Y, pointFrom.Z, pointTo.X, pointTo.Y, pointTo.Z);

   public static double Distance(double x1, double y1, double z1, double x2, double y2, double z2) =>
      Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
}

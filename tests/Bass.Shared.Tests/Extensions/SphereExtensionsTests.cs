using Bass.Shared.Extensions;
using Bass.Shared.Geometry;

namespace Bass.Shared.Tests.Extensions;

public class SphereExtensionsTests
{
   [Theory]
   [InlineData(7917, 196786852)]
   public void CalcSurfaceArea_Theory(int radius, long expected)
   {
      var sphere = new Sphere(radius);
      var area = sphere.CalcSurfaceArea();
      area.Should().Be(expected);
   }
}

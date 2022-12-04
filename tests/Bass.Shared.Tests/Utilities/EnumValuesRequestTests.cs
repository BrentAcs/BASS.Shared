using Bass.Shared.Utilities;

namespace Bass.Shared.Tests.Utilities;

public class EnumValuesRequestTests
{
   private SimpleRng _rng = new SimpleRng();

   public enum TestEnum
   {
      First,
      Second,
      Third,
      Fourth,
      Fifth
   }

   // --- GetValues

   [Fact]
   public void GetValues_WillReturn_UniqueValuesInSubset_WhenSet()
   {
      var sut = new EnumValuesRequest<TestEnum>();
   
      var values = sut.GetValues(_rng, 2);
   
      values.Distinct().Should().HaveCount(2);
   }
}

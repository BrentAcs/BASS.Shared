using Bass.Shared.Utilities;

namespace Bass.Shared.Tests.Utilities;

public class ValueRequestTests
{
   [Fact]
   public void AfterCtor_WithAbsoluteValue_SubsetSelection_WillBeNull()
   {
      var sut = new ValueRequest<int>(42);

      sut.SubsetSelection.Should().BeNull();
   }

   public void AfterCtor_WithSubsetSelection_AbsoluteValue_WillBeNull()
   {
      var sut = new ValueRequest<int>(new []{42,59});

      sut.AbsoluteValue.Should().be
   }
}

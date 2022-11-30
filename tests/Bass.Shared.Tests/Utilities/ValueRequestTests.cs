using System.Runtime.InteropServices;
using Bass.Shared.Utilities;

namespace Bass.Shared.Tests.Utilities;

public class IntValueRequestTests
{
   // After construction

   [Fact]
      // After construction
   
   public void AfterCtor_WithAbsoluteValue_SubsetSelection_WillBeNull()
      // After construction
   
   {
      // After construction
   
      var sut = new IntValueRequest(42);
         // After construction
      

      sut.SubsetSelection.Should().BeNull();
   }

   [Fact]
   public void AfterCtor_WithAbsoluteValue_MinMaxSelection_WillBeNull()
   {
      var sut = new IntValueRequest(42);

      sut.MinMaxSelection.Should().BeNull();
   }
   
   [Fact]
   public void AfterCtor_WithSubsetSelection_AbsoluteValue_WillBeNull()
   {
      var sut = new IntValueRequest(new []{42,59});
      
      sut.AbsoluteValue.Should().BeNull();
   }
   
   [Fact]
   public void AfterCtor_WithSubsetSelection_MinMaxSelection_WillBeNull()
   {
      var sut = new IntValueRequest(new []{42,59});

      sut.MinMaxSelection.Should().BeNull();
   }
   
   [Fact]
   public void AfterCtor_WithMinMaxSelection_AbsoluteValue_WillBeNull()
   {
      var sut = new IntValueRequest(new MinMax<int>(1,2));
      
      sut.AbsoluteValue.Should().BeNull();
   }
   
   [Fact]
   public void AfterCtor_WithMinMaxSelection_SubSetSelection_WillBeNull()
   {
      var sut = new IntValueRequest(new MinMax<int>(1,2));

      sut.SubsetSelection.Should().BeNull();
   }
}

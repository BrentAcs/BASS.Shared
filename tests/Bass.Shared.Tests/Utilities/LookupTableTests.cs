using Bass.Shared.Utilities;

namespace Bass.Shared.Tests.Utilities;

public class LookupTableTests
{
   [Fact]
   public void Add_AfterCall_ItemsWillContain_NewEntry()
   {
      var entry = new LookupTable<object>.Entry("item 1", 25);
      var sut = new LookupTable<object>();

      sut.Add(entry);

      sut.Items.Should().Contain(entry);
   }

   [Fact]
   public void Add_AfterCall_ItemsWillContain_EntriesSorted_ByChance()
   {
      var entry1= new LookupTable<object>.Entry("item 1", 25);
      var entry2= new LookupTable<object>.Entry("item 2", 15);
      var entry3= new LookupTable<object>.Entry("item 3", 5);
      var sut = new LookupTable<object>();

      sut.Add(entry1);
      sut.Add(entry2);
      sut.Add(entry3);

      sut.Items.Should().ContainInOrder(entry3, entry2, entry1);
   }
   
   [Fact]
   public void Add_AfterCall_ItemsWillContain_EntriesSorted_ByChance_WhenOneHasNullChance()
   {
      var entry1= new LookupTable<object>.Entry("item 1", 25);
      var entry2= new LookupTable<object>.Entry("item 2", 15);
      var entry3= new LookupTable<object>.Entry("item 3", 5);
      var entry4= new LookupTable<object>.Entry("item 4", null);
      var sut = new LookupTable<object>();

      sut.Add(entry1);
      sut.Add(entry2);
      sut.Add(entry3);
      sut.Add(entry4);

      sut.Items.Should().ContainInOrder(entry3, entry2, entry1, entry4);
   }

   [Fact]
   public void Add_WillThrow_WhenChanceIsNull_AndItemsAlreadyContainsChanceWithNull()
   {
      var entry1= new LookupTable<object>.Entry("item 1", null);
      var entry2= new LookupTable<object>.Entry("item 2", 15);
      var entry3= new LookupTable<object>.Entry("item 3", null);
      var sut = new LookupTable<object>();

      sut.Add(entry1);
      sut.Add(entry2);
      var act = () => sut.Add(entry3);

      act.Should().Throw<InvalidOperationException>();
   }

}

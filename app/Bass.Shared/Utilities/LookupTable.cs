namespace Bass.Shared.Utilities;

public class LookupTable<T> where T : class?
{
   public class Entry
   {
      public Entry()
      {
      }

      public Entry(string name, double? chance, T? data = null)
      {
         Name = name;
         Chance = chance;
         Data = data;
      }

      public string Name { get; set; } = string.Empty;
      public double? Chance { get; set; }
      public T? Data { get; set; }
   }

   private List<Entry> _items = new();

   public IEnumerable<Entry> Items => GetItems();

   public IEnumerable<Entry> GetItems() 
   {
      var items = _items.OrderBy(_ => _.Chance).ToList();
      if (!items.Any())
         return items;

      if (items[ 0 ].Chance is not null)
         return items;

      var tmp = items[ 0 ];
      items.RemoveAt(0);
      items.Add(tmp);

      return items;
   }
   
   public void Add(string name, double? chance, T? data = null) =>
      Add(new Entry
      {
         Name = name,
         Chance = chance,
         Data = data
      });

   public void Add(Entry entry)
   {
      if (entry.Chance is null && _items.Any(_ => _.Chance is null))
         throw new InvalidOperationException();
      
      _items.Add(entry);
   }
}

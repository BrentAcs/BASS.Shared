using Bass.Shared.Extensions;

namespace Bass.Shared.Utilities;

public class ValueRequest<T>
{
   private bool _useAbsoluteValue;
   private T? _absoluteValue;
   private IEnumerable<T>? _subsetSelection;

   public ValueRequest()
   {
   }

   public ValueRequest(T absoluteValue)
   {
      _absoluteValue = absoluteValue;
      _useAbsoluteValue = true;
   }

   public ValueRequest(IEnumerable<T>? subsetSelection)
   {
      _subsetSelection = subsetSelection;
   }
   
   public T? AbsoluteValue
   {
      get => _absoluteValue;
      set => SetAbsoluteValue(value);
   }

   public bool UseAbsoluteValue => _useAbsoluteValue;

   public IEnumerable<T>? SubsetSelection
   {
      get => _subsetSelection;
      set => SetSubsetSelection(value);
   }

   public T GetValue(IRng rng)
   {
      if (_useAbsoluteValue)
         return _absoluteValue!;

      if (_subsetSelection is not null)
         return rng.Next(_subsetSelection);
      
      throw new NotImplementedException();
   }

   public IEnumerable<T> GetValues(IRng rng, int uniqueCount)
   {
      if (_subsetSelection is null)
         throw new InvalidOperationException("GetValues called w/o a subset selection.");
      if (uniqueCount < 0)
         throw new ArgumentOutOfRangeException(nameof(uniqueCount), "Must be positive.");
      if (uniqueCount > _subsetSelection.Count())
         throw new ArgumentOutOfRangeException(nameof(uniqueCount), "Must be less than or equal to subset selection count.");
      
      var values = new List<T>();

      for (int i = 0; i < uniqueCount; i++)
      {
         T value = rng.Next(_subsetSelection);
         while (values.Contains(value))
         {
            value = rng.Next(_subsetSelection);
         }
         
         values.Add(value);         
      }

      return values;
   }
   
   private void SetAbsoluteValue(T? value)
   {
      if (value is null)
         throw new ArgumentNullException(nameof(value));
      
      _absoluteValue = value;
      _useAbsoluteValue = true;
      _subsetSelection = null;
   }

   private void SetSubsetSelection(IEnumerable<T>? value)
   {
      _absoluteValue = default;
      _useAbsoluteValue = false;
      _subsetSelection = value;
   }
}

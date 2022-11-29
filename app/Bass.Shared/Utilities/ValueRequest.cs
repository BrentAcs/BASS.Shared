namespace Bass.Shared.Utilities;

public class ValueRequest<T>
{
   private T? _absoluteValue;
   private IEnumerable<T>? _subsetSelection;

   public ValueRequest()
   {
   }

   public ValueRequest(T absoluteValue)
   {
      _absoluteValue = absoluteValue;
   }

   public ValueRequest(IEnumerable<T>? subsetSelection)
   {
      _subsetSelection = subsetSelection;
   }


// - AbsoluteValue
// - SubsetSelection: IEnumerable<T>
// - MinMax<T>
// - Value

   public T? AbsoluteValue
   {
      get => _absoluteValue;
      //set => SetAbsoluteValue(value);
   }

   public IEnumerable<T>? SubsetSelection
   {
      get => _subsetSelection;
      //set;
   }

   // public T GetValue(IRng rng)
   // {
   //
   //    return default;
   // }
}

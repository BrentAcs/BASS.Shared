using System.Numerics;

namespace Bass.Shared.Utilities;

public class NumberRequest<T> : ValueRequest<T> where T : INumber<T>
{
   private MinMax<T>? _rangeSelection;
 
   public NumberRequest(MinMax<T>? rangeSelection) 
   {
      _rangeSelection = rangeSelection;
   }
 
   public MinMax<T>? RangeSelection
   {
      get => _rangeSelection;
      //set;
   }
}

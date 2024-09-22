using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics.Task3
{
  internal class CarComparer : IComparer<Car>
  {
    public int Compare(Car? car1, Car? car2)
    {
      if(car1 is null || car2 is null)
        throw new ArgumentNullException("Некорректные значения");
      return car1.Make.Length - car2.Make.Length;
    }
    public int CompareModel(Car? car1, Car? car2)
    {
      if (car1 is null || car2 is null)
        throw new ArgumentNullException("Некорректные значения");
      return car1.Model.Length - car2.Model.Length;
    }
  }
}

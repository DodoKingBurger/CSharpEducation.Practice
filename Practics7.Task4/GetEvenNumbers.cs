using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics7.Task4
{
  internal class GetEvenNumber
  {
    public IEnumerator<int> GetEvenNumbers(int p1, int p2)
    {
      for (int i = p1; i <= p2; i++)
        if (i % 2 == 0)
          yield return i; 
    }
  }
}

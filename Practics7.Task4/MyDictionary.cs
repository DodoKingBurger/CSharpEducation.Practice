using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics7.Task4
{
  internal class MyDictionary : IEnumerator
  {
    public Dictionary<string, int> Items;
    int position = -1;

    public object Current
    {
      get
      {
        if (position == -1 || position >= Items.Count)
          throw new ArgumentException();
        return Items;
      }
    } 

    public bool MoveNext()
    {
      if (position < Items.Count - 1)
      {
        position++;
        return true;
      }
      else
        return false;
    }

    public void Reset() => position = -1;
  }
}

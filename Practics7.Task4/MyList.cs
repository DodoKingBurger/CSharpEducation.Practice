using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics7.Task4
{
  internal class MyList : IEnumerable
  {
    public List<int> items { get; set; }
    public IEnumerator GetEnumerator()
    {
      return this.items.GetEnumerator();
    }
  }
}

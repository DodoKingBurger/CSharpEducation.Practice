using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics7.Task1
{
  class ListStorage<T>: IStorage<T>
  {
    public List<T> ListItem;

    public int Count => ListItem.Count();

    public void Add(T item)
    {
      if (item != null)
      {
        ListItem.Add(item);
      }
      else
      {
        throw new ArgumentNullException("item == null");
      }
    }

    public T Get(int index)
    {
      if(ListItem.Count>= index)
      {
        return ListItem[index];
      }
      else
      {
        throw new ArgumentOutOfRangeException("index юольще чем есть в хранилище");
      }
    }
    public ListStorage()
    {
      ListItem = new List<T>();
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics7.Task1
{
  internal interface IStorage<T>
  {
    /// <summary>
    /// свойство, возвращающее общее количество элементов в хранилище.
    /// </summary>
    int Count { get; }

    /// <summary>
    /// Добавляет элемент `item` в хранилище.
    /// </summary>
    /// <param name="item"></param>
    void Add(T item);
    /// <summary>
    /// возвращает элемент из хранилища по указанному индексу.
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    T Get(int index);
  }
}

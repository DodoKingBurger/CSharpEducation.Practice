using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics7.Task5
{
  internal class Matrix
  {
    public int[,] Data;
    public int this[int index1, int index2]
    {
      get => Data[index1, index2];
      set => Data[index1, index2] = value;
    }
  }
}

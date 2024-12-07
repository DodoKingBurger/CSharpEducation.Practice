using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics7.Task2
{
  internal class Rectangle : ICloneable
  {
    public float Width;
    public float Height;

    public Rectangle(float width, float height)
    {
      this.Width = width;
      this.Height = height;
    }

    public object Clone()
    {
      return MemberwiseClone();
    }
  }
}

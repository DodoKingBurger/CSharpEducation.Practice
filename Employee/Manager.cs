using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5.Task1
{
  internal class Manager : Employee
  {
    public override float CalculateBonus()
    {
      return (float)(Salary * 0.2);
    }
  }
}

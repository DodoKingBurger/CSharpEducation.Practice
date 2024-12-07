using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics7.Task6
{
  internal class Program
  {
    static void Main(string[] args)
    {
    }
    static bool IsPalindrome(string str)
    {
      string normalizedStr = str.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "");
      char[] charArray = normalizedStr.ToCharArray();
      Array.Reverse(charArray);
      string reversedStr = new string(charArray);
      return normalizedStr == reversedStr;
    }
    static void ToTitleCase(ref string str) 
    {
      if (string.IsNullOrEmpty(str))
        throw new ArgumentNullException(nameof(str));
      string[] strArray = str.Split(' ');
      for (int i = 0; i < strArray.Length; i++)
      {
        if (!string.IsNullOrEmpty(strArray[i]))
        {
          char firstLetter = char.ToUpper(strArray[i][0]);
          strArray[i] = firstLetter + strArray[i].Substring(1);
        }
      }
      str = string.Join(" ", strArray);
    }
  }
}

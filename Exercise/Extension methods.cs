using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class MyExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
  
}

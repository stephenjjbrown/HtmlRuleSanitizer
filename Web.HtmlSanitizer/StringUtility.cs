using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vereyon.Web
{
    public static class StringUtility
    {
        public static bool IsNullOrWhiteSpace(string str)
        {
            if (str != null)
            {
                foreach (char c in str)
                {
                    if (Char.IsWhiteSpace(c) == false)
                        return false;
                }
            }
            return true;
        }
    }
}

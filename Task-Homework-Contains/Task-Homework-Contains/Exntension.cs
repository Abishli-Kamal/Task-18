using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Homework_Contains
{
    internal static class Exntension
    {
        public static bool customContains(this string word, string substring)
        {
          
            int k=0;
            foreach (var item in word)
            {
                if (k== substring.Length)
                {
                    if (item==  substring[k])
                    {
                        k++;
                            
                    }
                    else if (item!=substring[k])
                    {
                        k = 0;
                    }
                }
                else
                {
                    break;
                }
            }
            if(k== substring.Length)
            {
                return false;
            }
            else
            {
                    return true;
            }
           
          
        }

    }
}

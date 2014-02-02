using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Versaler.Model
{
    public class TextAnalyzer
    {
        public static int GetNumberOfC(string input)
        {
            string box = input;
            int count = 0;
            for (int i = 0; i < box.Length; i++)
            {
                if (char.IsUpper(box[i]))
                {
                    count++;
                }

            }
            return   count; 


        }
    }
}




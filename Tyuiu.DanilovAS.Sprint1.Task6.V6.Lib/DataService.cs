using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DanilovAS.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            string[] words = value.Split(' ');
            string result = "";

            foreach (string i in words)
            {
                if (i.Length > 1)
                {
                    string temp = i.Substring(1);

                    result += temp + " ";
                }

                //else if  (i.Length == 1) {
                 //   result += i + " ";
                //}

            }


            return result.Trim();
        }
    }
}

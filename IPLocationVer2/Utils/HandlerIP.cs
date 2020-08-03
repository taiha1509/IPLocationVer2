using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPLocationVer2.Utils
{
    public class HandlerIP
    {
        public HandlerIP() { }

        public static string ConvertIPToHexString(string IP)
        {      
            var arr = IP.Split(".");
            string x1 = Int32.Parse(arr[0]).ToString("X2");
            string x2 = Int32.Parse(arr[1]).ToString("X2");
            string x3 = Int32.Parse(arr[2]).ToString("X2");
            string x4 = Int32.Parse(arr[3]).ToString("X2");
            string res = "";
            for (int i = 0; i < 24; i++)
            {
                res += "0";
            }
            res += x1 + x2 + x3 + x4;
            return res;      
        }

        // return : 0: equal; -1: A < B; 1 A > B
        public static int CompareHexString(string A, string B)
        {
            int len = A.Length;
            for(int i = 0; i < len; i++)
            {
                if (A.ElementAt(i) < B.ElementAt(i))
                    return -1;
                else if (A.ElementAt(i) > B.ElementAt(i))
                    return 1;
            }


            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wechat.DAL.utilitymes
{
  public class PrivateImplementationDetails
    {
        public static uint ComputeStringHash(string s)
        {
            uint num=0;
            if (s != null)
            {
                num = 2166136261U;
                for (int i = 0; i < s.Length; i++)
                {
                    num = (s[i] ^ num) * 16777619U;
                }
            }
            return num;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreWebAPI.Model
{
    public class Caculate
    {
        public int addNum(int a , int b)
        {
            try
            {
                int sum = a +b;

                return sum;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

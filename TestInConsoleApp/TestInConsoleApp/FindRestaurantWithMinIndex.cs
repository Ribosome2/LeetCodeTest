using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class FindRestaurantWithMinIndex
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            List<string> resultList=new List<string>();
            int indexSum = int.MaxValue;
            for (int i = 0; i < list1.Length; i++)
            {
                string str = list1[i];
                for (int j = 0; j < list2.Length; j++)
                {
                    if (list2[j] == str)
                    {
                        int sum = i + j;
                        if (sum < indexSum)
                        {
                            resultList.Clear();
                            resultList.Add(str);
                            indexSum = sum;
                        }else if (sum == indexSum)
                        {
                            resultList.Add(str);
                        }
                        break;
                    }
                }
            }
            return resultList.ToArray();
        }
    }
}

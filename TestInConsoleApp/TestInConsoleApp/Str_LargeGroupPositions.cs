using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Str_LargeGroupPositions
    {
        public IList<IList<int>> LargeGroupPositions(string S)
        {
            List<IList<int>> resList=new List<IList<int>>();
            int left = 0;
            char temp = S[0];
            for (int i = 1; i < S.Length; i++)
            {
                char ch = S[i];
                if (ch != temp)
                {
                    if (i - left > 3)
                    {
                        resList.Add(new List<int>(){left,i-1});
                    }

                    left = i;
                    temp = ch;
                }
            }
            if (S.Length - left >= 3)
            {
                resList.Add(new List<int>() { left, S.Length - 1 });
            }
            return resList;
        }
    }
}
using System.Text;

namespace TestInConsoleApp
{
    public class Str_BackspaceCompare
    {
        public bool BackspaceCompare(string S, string T)
        {
            StringBuilder sb1=new StringBuilder();
            StringBuilder sb2=new StringBuilder();
            foreach (char c in S)
            {
                if (c == '#' )
                {
                    if (sb1.Length>0)
                    {
                        sb1.Remove(sb1.Length - 1, 1);
                    }
                }
                else
                {
                    sb1.Append(c);
                }
            }

            foreach (char c in T)
            {
                if (c == '#' )
                {
                    if (sb2.Length > 0)
                    {
                        sb2.Remove(sb2.Length - 1, 1);
                    }
                }
                else
                {
                    sb2.Append(c);
                }
            }

            return sb1.ToString() == sb2.ToString();
        }
    }
}
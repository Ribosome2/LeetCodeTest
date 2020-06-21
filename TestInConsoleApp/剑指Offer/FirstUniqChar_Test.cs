namespace 剑指Offer
{
    public class FirstUniqChar_Test
    {
        public char FirstUniqChar(string s)
        {
            int[] arr= new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                var numIndex = s[i]-'a';
                arr[numIndex]++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                var numIndex = s[i] - 'a';
                if (arr[numIndex] == 1)
                {
                    return (char)('a' + numIndex);
                }
            }
            return ' ';
        }
    }
}
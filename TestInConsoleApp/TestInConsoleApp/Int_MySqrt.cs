namespace TestInConsoleApp
{
    public class Int_MySqrt
    {
        public int MySqrt(int x)
        {
            if (x <= 1)
            {
                return x;
            }

            int r = x;
            while (r > x / r)
            {
                r = (r + x / r) / 2;
            }

            return (r);
        }
    }
}
namespace TestInConsoleApp
{
    public class IsCanWinNim
    {
//        你和你的朋友，两个人一起玩 Nim游戏：
//        桌子上有一堆石头，每次你们轮流拿掉 1 - 3 块石头。
//        拿掉最后一块石头的人就是获胜者。你作为先手。
        public bool CanWinNim(int n)
        {
            return (n % 4 !=0);
        }
    }
}
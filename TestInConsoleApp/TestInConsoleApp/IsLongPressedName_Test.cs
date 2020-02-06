using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class IsLongPressedName_Test
    {
//        你的朋友正在使用键盘输入他的名字 name。偶尔，在键入字符 c时，按键可能会被长按，而字符可能被输入 1 次或多次。
//
//        你将会检查键盘输入的字符 typed。如果它对应的可能是你的朋友的名字（其中一些字符可能被长按），那么就返回 True。
//
//        来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/long-pressed-name
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public bool IsLongPressedName(string name, string typed)
        {
            int typeIndex = 0;
            int nameIndex = 0;
            while (nameIndex<name.Length)
            {
                bool flag = false;
                var ch = name[nameIndex];
                while (typeIndex<typed.Length)
                {
                    if (ch == typed[typeIndex])
                    {
                        flag = true;
                        typeIndex++;
                        if (nameIndex < name.Length - 1 && name[nameIndex + 1] == ch)
                        {
                            //下一个字符跟当前的一样，不再往下检查
                            break;
                        }
                    }
                    else
                    {
                       break;
                    }
                }

                if (flag == false)
                {
                    return false;
                }
                nameIndex++;
            }
            return true;

        }
    }
}

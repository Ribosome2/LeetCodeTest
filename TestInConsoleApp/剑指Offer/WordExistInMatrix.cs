using System.Xml;

namespace 剑指Offer
{
    public class WordExistInMatrix
    {
//        请设计一个函数，用来判断在一个矩阵中是否存在一条包含某字符串所有字符的路径。路径可以从矩阵中的任意一格开始，每一步可以在矩阵中向左、右、上、下移动一格。如果一条路径经过了矩阵的某一格，那么该路径不能再次进入该格子。例如，在下面的3×4的矩阵中包含一条字符串“bfce”的路径（路径中的字母用加粗标出）。
//
//        来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/ju-zhen-zhong-de-lu-jing-lcof
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public bool Exist(char[][] board, string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            bool[][] visited =new bool[board.Length][];
            for (int i = 0; i < board.Length; i++)
            {
                var arr = board[i];
                visited[i] = new bool[arr.Length];
            }

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    if (board[row][col] == word[0])
                    {
                        visited[row][col] = true;
                        if (FindWord(board, word, visited, row, col, 1))
                        {
                            return true;
                        }
                        visited[row][col]=false;
                    }
                }
            }

            return false;
        }


        bool FindWord(char[][] board, string word, bool[][] visited,int row, int col, int index)
        {
            if (index >= word.Length)
            {
                return true;
            }

            //LEFT 
            if (CheckCompleteWord(board, ref word, visited, index, row, col-1))
            {
                return true;
            }
            //RIGHT
           
            if (CheckCompleteWord(board, ref word, visited, index, row, col+1))
            {
                return true;
            }
            //UP
            if (CheckCompleteWord(board, ref word, visited, index, row - 1, col))
            {
                return true;
            }
            //DOWN
            if (CheckCompleteWord(board, ref word, visited, index, row + 1, col))
            {
                return true;
            }

            return false;
        }

        private bool CheckCompleteWord(char[][] board, ref string word, bool[][] visited, int index, int curRow, int curCol)
        {
            if (CheckNextCharAtIndex(board, visited, curRow, curCol, index, ref word))
            {
                visited[curRow][curCol] = true;
                if (FindWord(board, word, visited, curRow, curCol, index + 1))
                {
                    return true;
                }

                visited[curRow][curCol] = false;
            }

            return false;
        }

        bool CheckNextCharAtIndex(char[][] board, bool[][] visited,  int curRow, int curCol, int index,ref string word)
        {
            if (curRow >= 0 && curRow < board.Length && curCol >= 0 && curCol < board[curRow].Length)
            {
                if (visited[curRow][curCol] == false && word[index]==board[curRow][curCol])
                {
                    return true;
                }
            }
            return false;
        }

    }
}
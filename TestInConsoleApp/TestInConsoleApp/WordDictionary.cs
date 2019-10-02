using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
//    earch(word) 可以搜索文字或正则表达式字符串，字符串只包含字母.或 a-z 。 . 可以表示任何一个字母。
//    你可以假设所有单词都是由小写字母 a-z 组成的。
    public class WordDictionary
    {
        private Trie mTrie =new Trie();
        /** Initialize your data structure here. */
        public WordDictionary()
        {
        }

        /** Adds a word into the data structure. */
        public void AddWord(string word)
        {
            mTrie.Insert(word);
        }

        /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
        public bool Search(string word)
        {
            return mTrie.SearchWithDotCheck(word);
        }
    }

    /**
     * Your WordDictionary object will be instantiated and called as such:
     * WordDictionary obj = new WordDictionary();
     * obj.AddWord(word);
     * bool param_2 = obj.Search(word);
     */
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
//    说明:
//
//    你可以假设所有的输入都是由小写字母 a-z 构成的。
//    保证所有输入均为非空字符串。
    public class Trie
    {
        public class TrieNode
        {
            private TrieNode[] childList;
            public bool HasEndHere = false;
            public void AddChild(int index)
            {
                if (childList == null)
                {
                    childList= new TrieNode[26];
                }
                childList[index]=new TrieNode();
            }

            public TrieNode GetChildNode(int index)
            {
                if (childList != null)
                {
                    return childList[index];
                }
                return null;
            }
        }


        private TrieNode root;


        /** Initialize your data structure here. */
        public Trie()
        {
            root=new TrieNode();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            TrieNode parentNode = root;
            for (int i = 0; i < word.Length; i++)
            {
                int number = word[i] - 97;
                if (parentNode.GetChildNode(number) == null)
                {
                    parentNode.AddChild(number);
                }
                parentNode = parentNode.GetChildNode(number);
            }
            parentNode.HasEndHere = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            TrieNode parentNode = root;
            for (int i = 0; i < word.Length; i++)
            {
                int number = word[i] - 97;
                parentNode = parentNode.GetChildNode(number);
                if (parentNode == null)
                {
                    return false;
                }
            }

            return parentNode.HasEndHere;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            TrieNode parentNode = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                int number = prefix[i] - 97;
                parentNode = parentNode.GetChildNode(number);
                if (parentNode== null)
                {
                    return false;
                }
            }

            return true;
        }
    }

    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */
}

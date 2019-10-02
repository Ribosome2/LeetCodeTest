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
            public void AddChild(char ch)
            {
                if (childList == null)
                {
                    childList= new TrieNode[26];
                }
                childList[ch-'a']=new TrieNode();
            }

            public TrieNode GetChildNode(char c)
            {
                if (childList != null)
                {
                    return childList[c-'a'];
                }
                return null;
            }

            public bool ContainKey(char c)
            {
                if (childList == null)
                {
                    return false;
                }
                return childList[c - 'a'] != null;
            }

            /// <summary>
            /// 当前字符为‘.’ 的时候才会进这里
            /// </summary>
            /// <param name="word"></param>
            /// <param name="startIndex"></param>
            /// <returns></returns>
            public bool CheckEveryChild(ref string word,int startIndex)
            {
               
                if (childList != null)
                {
                    for (int i = 0; i < childList.Length; i++)
                    {
                        var child = childList[i];
                        if (child!=null)
                        {
                            //通配任意字符的时候，如果已经是最后一个了，而且这一层有节点，就可以判断成功了
                            if (child.HasEndHere && startIndex==word.Length)
                            {
                                return true;
                            }

                            TrieNode parentNode = child;
                            for (int index = startIndex; index < word.Length; index++)
                            {
                                if (word[index] == '.')
                                {
                                    if (parentNode.CheckEveryChild(ref word, index + 1))
                                    {
                                        return true;
                                    }
                                    break;
                                }
                                else
                                {
                                    parentNode = parentNode.GetChildNode(word[index]);
                                    if (parentNode == null)
                                    {
                                        break;
                                    }

                                    if (parentNode.HasEndHere && index == word.Length - 1)
                                    {
                                        return true;
                                    }
                                }
                            }
                        }

                    }
                }

                return false;
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
                var ch = word[i];
                if (!parentNode.ContainKey(ch))
                {
                    parentNode.AddChild(ch);
                }
                parentNode = parentNode.GetChildNode(ch);
            }
            parentNode.HasEndHere = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            TrieNode parentNode = root;
            for (int i = 0; i < word.Length; i++)
            {
                parentNode = parentNode.GetChildNode(word[i]);
                if (parentNode == null)
                {
                    return false;
                }
            }

            return parentNode.HasEndHere;
        }

        public bool SearchWithDotCheck(string word)
        {
            TrieNode parentNode = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '.')
                {
                    return parentNode.CheckEveryChild(ref word, i + 1);
                }
                parentNode = parentNode.GetChildNode(word[i]);
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
                parentNode = parentNode.GetChildNode(prefix[i]);
                if (parentNode== null)
                {
                    return false;
                }
            }

            return true;
        }
    }
  
}

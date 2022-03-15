using System.Collections.Generic;
using System;

namespace CustomData
{
    public class KyleDictionary
    {

        private struct Entry
        {
            public int hashCode;
            public int next;
            public TKey key;
            public TValue value;
        }

        private Entry[] entries;
        private int[] buckets;

        private int count;
        private int freeList;
        private int freeCount;
        private int version;
        private IEqualityComparer<TKey> comparer;

        private void Insert(TKey key, TValue value, bool add)
        {
            //Calculate the hash code of the key ,eliminate negative values
            int hashCode = comparer.GetHashCode(key) & 0x7FFFFFFF;

            //Calculate the remainder of the hashCode divided by the number of buckets
            //This is the usual way of narrowing the value set of the hash code to the set of possible bucket indices
            int targetBucket = hashCode % buckets.Length;

            //Look at all the entries in the target bucket.
            //The next field of the entry points to to next entry in the chain,in case of collision
            //If there are no more items in che chain ,its value is -1
            //If we find the key in the dictionary,we update the associated value and return.
            for (int i = buckets[targetBucket]; i >= 0; i = entries[i].next)
            {
                if (entries[i].hashCode == hashCode && comparer.Equals(entries[i].key, key))
                {
                    entries[i].value = value;
                    version++; //what is this for ?
                    return;
                }
            }

            int index;
            if (freeCount > 0)
            {
                //There is a "hole" in the entries array, because something has been removed
                //The first empty place is pointed to by freeList ,we insert our entry there/
                index = freeList;
                freeList = entries[index].next;
                freeCount--;
            }
            else
            {
                //There are no "holes" in the entries array
                if (count == entries.Length)
                {
                    //The dictionary  is full , we need to increase its size by calling Resize().
                    //(After Resize,it's guaranteed that there are no holes in the array
                    Resize();
                    targetBucket = hashCode % buckets.Length;
                }

                //We can simply take the next consecutive place in the entries array
                index = count;
                count++;
            }

            //Setting the fields of the entry
            entries[index].hashCode = hashCode;
            entries[index].next = buckets[targetBucket];
            entries[index].key = key;
            entries[index].value = value;
            buckets[targetBucket] = index;
        }

        private void Resize()
        {
            
        }
    }


    internal interface TKey
    {
    }

    internal interface TValue
    {
    }


}

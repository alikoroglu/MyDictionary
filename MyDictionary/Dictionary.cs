using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<keyT,valT>
    {
        keyT[] myDictionaryKeys;
        keyT[] tempKeys;
        valT[] myDictionaryVals;
        valT[] tempVals;

        public Dictionary()
        {
            myDictionaryKeys = new keyT[0];
            myDictionaryVals = new valT[0];
        }

        public void Add(keyT K,valT V)
        {
            tempKeys = myDictionaryKeys;
            tempVals = myDictionaryVals;
            myDictionaryKeys = new keyT[tempKeys.Length + 1];
            myDictionaryVals = new valT[tempVals.Length + 1];
            for (int i = 0; i <tempKeys.Length; i++)
            {
                myDictionaryKeys[i] = tempKeys[i];
                myDictionaryVals[i] = tempVals[i];
            }
            myDictionaryKeys[myDictionaryKeys.Length - 1] = K;
            myDictionaryVals[myDictionaryVals.Length - 1] = V;
        }

        public int Count
        {
            get { return myDictionaryKeys.Length; }
        }

    }
}

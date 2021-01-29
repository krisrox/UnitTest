using System;

namespace Palindrom
{
    using System.Linq;

    public class PalindromSDP
    {
        public bool IsPalindrom(string myString)
        {
            myString = myString.Replace(" ", "").ToLower();
            int length = myString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (myString[i] != myString[length - i - 1])
                    return false;
            }

            return true;
        }

        public bool IsBetterPalindrom(string myString)
        {
            myString = myString.Replace(" ", "").ToLower();
            return myString.SequenceEqual(myString.Reverse());
        }
    }
}

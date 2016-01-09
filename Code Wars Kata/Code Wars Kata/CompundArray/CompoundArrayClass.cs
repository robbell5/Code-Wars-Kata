using System.Collections.Generic;

namespace Code_Wars_Kata.CompundArray
{
    public class CompoundArrayClass
    {
        public static int[] CompoundArray(int[] firstArray, int[] secondArray)
        {
            List<int> compoundList = new List<int>();

            for(int i = 0; i < firstArray.Length || i < secondArray.Length; i++ )
            {
                if (firstArray.Length > i)
                    compoundList.Add(firstArray[i]);

                if (secondArray.Length > i)
                    compoundList.Add(secondArray[i]);
            }

            return compoundList.ToArray();
        }
    }
}

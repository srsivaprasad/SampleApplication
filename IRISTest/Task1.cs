using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRISTest
{
    public class Task1
    {
        #region FindCommonElements
        /// <summary>
        /// Methode to find the common value from two int array object.
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static int[] FindCommonElements(int[] arr1, int[] arr2)
        {
            return arr1.Intersect(arr2).ToArray();
        }
        #endregion
    }
}

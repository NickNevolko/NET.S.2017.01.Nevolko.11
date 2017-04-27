using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Provides a generic method for binary search 
    /// </summary>
    public static class Task2
    {
        /// <typeparam name="T">user type</typeparam>
        /// <param name="arr">array of user type</param>
        /// <param name="item">value for search</param>
        /// <returns>returns an index of the first </returns>
        public static int BinarySearch<T>(T[] arr, T item) => BinarySearch(arr, item, Comparer<T>.Default);


        /// <typeparam name="T">user type</typeparam>
        /// <param name="arr">array of user type</param>
        /// <param name="item">value for search</param>
        /// <param name="comp">user comparator</param>
        /// <returns>returns an index of the first </returns>
        public static int BinarySearch<T>(T[] arr, T item, Comparison<T> comp) => BinarySearch(arr, item, Comparer<T>.Create(comp));


        /// <typeparam name="T">user type</typeparam>
        /// <param name="arr">array of user type</param>
        /// <param name="item">value for search</param>
        /// <param name="comp">user comparator</param>
        /// <returns>returns an index of the first </returns>
        public static int BinarySearch<T>(T[] arr, T item, IComparer<T> comp)
        {
            if (ReferenceEquals(arr, null)) throw new ArgumentNullException(nameof(arr));
            if (ReferenceEquals(comp, null)) throw new ArgumentNullException(nameof(comp));
            if (ReferenceEquals(item, null)) throw new ArgumentNullException(nameof(item));

            int left = 0;
            int right = arr.Length;

            while (!(left >= right))
            {
                int mid = left + (right - left) / 2;

                if (comp.Compare(item, arr[mid]) > 0)
                {
                    left = mid + 1;
                }
                else if (comp.Compare(item, arr[mid]) < 0)
                {
                    right = mid;
                }
                else
                    return mid;
            }
            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.BinarySearch
{

    public static class binarysearch
    {
        public static int Search(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                    return mid; 

                if (arr[mid] < target)
                    left = mid + 1; 
                else
                    right = mid - 1; 
            }

            return -1; 
        }
    }
}
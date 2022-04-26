using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class TestSearch
    {
        //二分查找复杂度O(log n)
        public static int BinarySearch(int[] arr, int target)
        {
            int l = 0;
            int r = arr.Length - 1;
            while (l <= r)
            {
                //会出现整型溢出
                //int mid = (l + r) / 2; 
                // l+(r-l)/2 = l+(r/2-l/2) = l/2 + r/2 = (l+r)/2
                int mid = l + (r - l) / 2;
                if (target < arr[mid])
                    r = mid - 1;            //在arr[l...mid-1]查找target
                else if (target > arr[mid])
                    l = mid + 1;            //在arr[mid+1...r]查找target
                else
                    return mid;             //找到target，并返回索引
            }

            return -1;
        }
    }
}

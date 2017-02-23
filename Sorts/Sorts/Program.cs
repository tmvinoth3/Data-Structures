using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorts
{
    class Program
    {
        //public void Swap(int a, int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        public void Bubble(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }

        }

        public void Insertion(int[] arr)
        {
            for (int i = 1; i < arr.Length-1; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && key < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        public void Selection(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int min_index = i;

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[min_index] > arr[j])
                        min_index = j;
                }
                int temp = arr[min_index];
                arr[min_index] = arr[i];
                arr[i] = temp;
            }
        }
        public void Merge(int[] arr,int l,int m,int r)
        {
            int i,j,k;
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] larr = new int[n1];
            int[] rarr = new int[n2];
            for (i = 0; i < n1; i++)
            {
                larr[i] = arr[l+i];   
            }
            for (j = 0; j < n2; j++)
            {
                rarr[j] = arr[m+1+j];
            }

            i = 0;
            j = 0;
            k = l;
            //copy smaller elements
            while (i < n1 && j < n2)
            {
                if (larr[i] <= rarr[j])
                {
                    arr[k] = larr[i];
                    i++;
                }
                else
                {
                    arr[k] = rarr[j];
                    j++;
                }
                k++;
            }
            //copy remaining elements
            while (i < n1)
            {
                arr[k] = larr[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = rarr[j];
                j++;
                k++;
            }

        }

        public void MergeSort(int[] arr,int l,int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;

                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);

                Merge(arr, l, m, r);
            }
        }

        public int Partition(int[] arr,int l,int h)
        {
            int i;
            int pivot = arr[h];
            i = l - 1;//intialize minimum index with -1
            for (int j = l; j <= h-1 ; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int t = arr[i + 1];
            arr[i + 1] = arr[h] ;
            arr[h] = t;
            return i+1;
        }
        public void Quick(int[] arr, int l, int h)
        {
            if (l < h)
            {
               int partIndex = Partition(arr,l,h);

               Quick(arr,l,partIndex-1);
               Quick(arr,partIndex+1,h);
            }
        }
        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 6, 3, 1, 4, 8 };
            Program p = new Program();
            //Console.WriteLine("Bubble");
            //p.Bubble(arr);
            //p.Print(arr);
            //Console.WriteLine("Insertion");
            //p.Insertion(arr);
            //p.Print(arr);
            //Console.WriteLine("Selection");
            //p.Selection(arr);
            //p.Print(arr);
            //Console.WriteLine("Merge");
            //p.MergeSort(arr,0,arr.Length-1);
            //p.Print(arr);
            Console.WriteLine("Quick");
            p.Quick(arr, 0, arr.Length - 1);
            p.Print(arr);
            Console.Read();
        }
    }
}

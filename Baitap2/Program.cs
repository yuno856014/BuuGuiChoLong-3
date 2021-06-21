using System;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            InitMenu();
        }
        static void InitMenu()
        {
            Console.WriteLine("nhap kich thuoc!");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($" Nhap so {i} phan tu");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] array = InitArray(arr);
            int choice = 0;
            do
            {
                Console.WriteLine("--------Menu--------");
                Console.WriteLine("1. Tao Mang         ");
                Console.WriteLine("2. Kiem tra mang tang     ");
                Console.WriteLine("3. sap xep mang     ");
                Console.WriteLine("4. tim kiem mang     ");
                Console.WriteLine("5. exit       ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = 1;
                }
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        InitArray(arr);
                        break;
                    case 2:
                        Console.Write(IsIncreaseArray(array,n));
                        break;
                    case 3:
                        SelectionSort(array);
                        break;
                    case 4:
                        Find(SelectionSort(array));
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);
        }    
        static int[] InitArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            return arr;
        }
        static bool IsIncreaseArray(int[] arr,int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int m = i;
                int minValue = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(minValue) < 0)
                    {
                        m = j;
                        minValue = arr[j];
                    }
                }
                int temp = arr[i];
                arr[i] = arr[m];
                arr[m] = temp;
            }
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            return arr;
        }
        static void Find(int[] arr)
        {
            int first, middle, last, key;
            bool found = false;
            Console.WriteLine("Nhap vao gia tri tim kiem:");
            key = int.Parse(Console.ReadLine());
            first = 0;
            last = arr.Length - 1;
            while (first <= last)
            {
                middle = (first + last) / 2;

                if (arr[middle] < key)
                    first = middle + 1;
                else if (arr[middle] == key)
                {
                    Console.WriteLine("Tim gia tri {0} o vi tri {1} trong mang", key, (middle + 1));
                    found = true;
                    break;
                }
                else
                    last = middle - 1;
            }
            if (found == false)
                Console.WriteLine("khong tim thay gia tri tim kiem");
        }
    }
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var index = BinarySearch.UsingWhileLoop(array, 7);
Console.WriteLine(index.ToString());
index = BinarySearch.RecursiveLoop(array, 7,0,array.Length);
Console.WriteLine(index.ToString());

public static class BinarySearch
{
    public static int UsingWhileLoop(int[] array, int key)
    {
        int low = 0;
        int high = array.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] == key)
            {
                return mid;
            }
            else if (key < array[mid])
            {
                low = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return -1;
    }


    public static int RecursiveLoop(int[] array, int key, int low, int high)
    {
        if (high - 1 >= low)
        {
            var mid = low + (high - low) / 2;
            if (array[mid] == key)
            {
                return mid;
            }
            if (array[mid] < key)
            {
                return RecursiveLoop(array, key, mid + 1, high);
            }
            else
            {
                return RecursiveLoop(array, key, low, mid - 1);
            }
        }
        else
        {
            return -1;
        }

    }
}

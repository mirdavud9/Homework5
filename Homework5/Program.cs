namespace StackHeapRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            CustomResize(ref numbers, 4, 5, 6, 7);

            Console.WriteLine("deyirdirilmis array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public static void CustomResize(ref int[] arr, params int[] newValues)
        {
            int newSize = arr.Length + newValues.Length;
            int[] newArr = new int[newSize];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            for (int i = 0; i < newValues.Length; i++)
            {
                newArr[arr.Length + i] = newValues[i];
            }

            arr = newArr;
        }
    }
}
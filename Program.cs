using System;

class Program
{
    static void Main(string[] args)
    {
        #region task1
        //// Input: getting array length from the user
        //Console.WriteLine("Enter array length:");
        //int len = int.Parse(Console.ReadLine());

        //// Initialize array
        //int[] arr = new int[len];

        //// Fill array with user input
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine($"Enter element [{i}]:");
        //    arr[i] = int.Parse(Console.ReadLine());
        //}

        //// Initialize a variable to store the maximum distance
        //int maxDistance = 0;

        //// Nested loop to calculate the distance between two equal elements
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    for (int j = i + 1; j < arr.Length; j++)  // Start from i + 1 to avoid duplicate comparisons
        //    {
        //        if (arr[i] == arr[j])
        //        {
        //            int distance = j - i;
        //            if (distance > maxDistance)
        //            {
        //                maxDistance = distance;  // Update maxDistance if the current distance is larger
        //            }
        //        }
        //    }
        //}

        //// Output: display the maximum distance found
        //Console.WriteLine($"The longest distance between two equal elements is: {maxDistance}");
        #endregion

        #region task2
        //Console.WriteLine("Enter a sentence:");
        //string input = Console.ReadLine();

        //// Split the input string by spaces, reverse the resulting array, and join it back into a string
        //Console.WriteLine(string.Join(" ", input.Split(' ').Reverse()));
        #endregion
        int count = 0;
        for (int i=0; i < 1000000000; i++)
        {
            String j= i.ToString();
            
            foreach (char c in j)
            {
                if (c == '1') count++;
            }

        }
        Console.WriteLine($"Total occurrences of '1': {count}");

    }
}


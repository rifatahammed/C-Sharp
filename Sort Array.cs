// C# program sort an array in decreasing order
// using Array.Sort() and Array.Reverse() Method
using System;

class SortArray {

	// Main Method
	public static void Main()
	{

		// declaring and initializing the array
		int[] arr = new int[] {1, 9, 6, 7, 5, 9};

		// Sort array in ascending order.
		Array.Sort(arr);
		// print all element of array
		foreach(int value in arr)
		{
			Console.Write(value + " ");
		}
        Console.Write("\n\n");
		// reverse array
		Array.Reverse(arr);

		// print all element of array for reverse
		foreach(int value in arr)
		{
			Console.Write(value + " ");
		}
	}
}

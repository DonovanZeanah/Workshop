
using WorkshopModels;
using WorkshopDB;

namespace WorkshopConsole
{
		internal class Program
		{
				static void Main(string[] args)
				{
						SlidingAverage();








						

						Console.WriteLine("Hello, World!");
				}

				private static void SlidingAverage()
				{
						int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }; // 20 };

						for (int i = 0; i < array.Length; i++)
						{
								var nextArray = array[i + 1];
								var currArray = array[i];
								var result = currArray * nextArray / 2;
								var result2 = currArray + nextArray;

								Console.WriteLine($"{array[i]} * {array[i + 1]} is: {result}");
								Console.WriteLine($"{array[i]} + {array[i + 1]} is: {result2}");


						}
				}
		}
}
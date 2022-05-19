// See https://aka.ms/new-console-template for more information
using ThreeValueArraySortingTest;

Console.WriteLine("Beginning sorter trial.");

Console.Write("Please enter the length of your array: ");
var input = Console.ReadLine();
int length = int.Parse(input);

Console.WriteLine("Initializing array...");
int[] array = new int[length];
Random random = new Random();
for (int i = 0; i < length; ++i) array[i] = random.Next(3);

new CountingSorter().Sort((int[]) array.Clone());
new ShrinkingSorter().Sort((int[]) array.Clone());
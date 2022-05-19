# ThreeValueArraySortingTest

This is just a funny program to settle a debate. Feel free to test it, fork the project, and confront your own sorting algorithms to mine!

## Initial instructions

You have an array of 0s, 1s and 2s. Sort the array in the fastest way possible.

## Program structure

### Program.cs

This is the basic script, which generates a random array of a length you determine, and then hands a clone of that array to every single sorter to then test it.

To add your own sorter to the mix, just add `new YourSorter().Sort((int[]) array.Clone())` at the end of the script.

### Sorter abstract class

If you wish to create a sorter, inherit from this class. It wraps an abstract `SortingAlgorithm` method in a `Sort` method template, which measures the time SortingAlgorithm took to execute and prints it to the console.

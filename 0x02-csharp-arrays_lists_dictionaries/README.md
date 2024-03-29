# 0x02. C# - Data Structures: Arrays, Lists, Dictionaries

## 0. Print an array of integers
Creates and prints an array of integers of a given size.
* Class Name: Array
* Prototype: public static int[] CreatePrint(int size)
* Returns the new array
* The integers in the array should start with 0 and increment by one until the given size is met (see output below)
* If size is 0, print a blank line
* If size is less than 0, print Size cannot be negative and return null

## 1. Access an element in an array
Retrieves an element from an array.
* Class Name: Array
* Prototype: public static int elementAt(int[] array, int index)
* Returns the element at the given index
* If index is out of range, print Index out of range and return -1

## 2. Replace element
Replaces an element of an array at a given index.
* Class Name: Array
* Prototype: public static int[] ReplaceElement(int[] array, int index, int n)
* Returns the updated array
* If index is out of range, print Index out of range and return the unchanged array

## 3. Print an array of integers... in reverse!
Prints all integers of an array, in reverse order.
* Class Name: Array
* Prototype: public static void Reverse(int[] array)

## 4. Print a list of integers
Creates and prints a list of integers of a given size.
* Class Name: List
* Prototype: public static List<int> CreatePrint(int size)
* The integers in the list should start with 0 and increment by one until the given size is met (see output below)
* Returns the newly created list
* If size is less than 0, print Size cannot be negative and return null

## 5. Find the max
Finds the biggest integer of a list.
* Class Name: List
* Prototype: public static int MaxInteger(List<int> myList)
* Returns the largest element in a given list
* If list is empty, print List is empty and return -1
* You are not allowed to use LINQ or .Max()

## 6. Only by 2
Finds all multiples of 2 in a list.
* Class Name: List
* Prototype: public static List<bool> DivisibleBy2(List<int> myList)
* Returns a new list containing true or false, depending on whether the integer at the same position in the original list is a multiple of 2
* The new list should have the same size as the original list

## 7. Delete at
Deletes the item at a specific position in a list.
* Class Name: List
* Prototype: public static List<int> DeleteAt(List<int> myList, int index)
* Returns the updated list
* If index is out of range, print Index is out of range and return the unchanged list
* You are not allowed to use .RemoveAt()

## 8. Number of keys
Returns the number of keys in a dictionary.
* Class Name: Dictionary
* Prototype: public static int NumberOfKeys(Dictionary<string, string> myDict)
* Returns the number of keys in a dictionary
* You are not allowed to use .Count()

## 9. Update dictionary
Adds a key and value to a dictionary.
* Class Name: Dictionary
* Prototype: public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
* If a key exists in the dictionary, the value will be replaced
* If a key doesn’t exist in the dictionary, it will be created
* Returns the updated dictionary

## 10. Delete from dictionary
Deletes a key in a dictionary
* Class Name: Dictionary
* Prototype: public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
* Returns the updated dictionary

## 11. Multiply by 2
Returns a new dictionary with all values multiplied by 2.
* Class Name: Dictionary
* Prototype: public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
* Returns the new dictionary

## 12. Print sorted dictionary
Prints a dictionary by ordered keys.
* Class Name: Dictionary
* Prototype: public static void PrintSorted(Dictionary<string, string> myDict)
* You are not allowed to use SortedDictionary
* Output should be formatted as in the example below

## 13. Best score
Returns the key with the biggest integer value in a given dictionary.
* Class Name: Dictionary
* Prototype: public static string BestScore(Dictionary<string, int> myList)
* Returns the key with the biggest integer value
* You can assume that all values are non-negative integers
* You can assume that all students have a different score
* If no scores are found, return “None”

## 14. Rectangular array
Creates and prints a 5 by 5 two-dimensional array and initialize index [2,2] to 1 and all other indices to 0.

## 15. Matrix squared
Computes the square value of all integers of a matrix.
* Class Name: Matrix
* Prototype: public static int[,] Square(int[,] myMatrix)
* Returns a new matrix containing the square value of all integers of the original matrix

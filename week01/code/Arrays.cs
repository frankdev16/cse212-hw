public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Create a new array of doubles with a fixed size equal to the 'length' parameter.
        // Step 2: Set up a standard for loop that starts at index 0 and runs 'length' times.
        // Step 3: Inside the loop, calculate the current multiple by multiplying the starting 'number' by (index + 1).
        // Step 4: Assign that calculated multiple into the array at the current index.
        // Step 5: After the loop finishes filling the array, return the array.

        // Step 1: Create a new array of doubles with a fixed size equal to the 'length' parameter.
        double[] results = new double[length];

        // Step 2: Set up a standard for loop that starts at index 0 and runs 'length' times.
        for (int i = 0; i < length; i++)
        {
            // Step 3 & 4: Calculate the current multiple by multiplying the starting 'number' by (index + 1)
            // and assign that calculated multiple into the array at the current index.
            results[i] = number * (i + 1);
        }

        // Step 5: After the loop finishes filling the array, return the array.
        return results;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Find the index where we need to make our "cut". We do this by subtracting the 'amount' from the total length of the list.
        // Step 2: Make a copy of the numbers from the "cut" index to the end of the list using GetRange.
        // Step 3: Remove those numbers from the end of the original list using RemoveRange.
        // Step 4: Insert our copied numbers at the very beginning (index 0) of the original list using InsertRange.

        // Step 1: Find the index where we need to make our "cut"
        int cutIndex = data.Count - amount;

        // Step 2: Make a copy of the numbers from the "cut" index to the end of the list
        List<int> tail = data.GetRange(cutIndex, amount);

        // Step 3: Remove those numbers from the end of the original list
        data.RemoveRange(cutIndex, amount);

        // Step 4: Insert our copied numbers at the very beginning (index 0) of the original list
        data.InsertRange(0, tail);
    }
}

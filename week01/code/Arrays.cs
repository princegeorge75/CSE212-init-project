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
        // Step 1: Create a new array of type double with the size equal to 'length'.
        // Step 2: use a for loop to fill each element of the array.
        // Step 3: For each index i (starting from 0), store the value: number * (i + 1).
        // Step 4: After the loop, return the filled array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;}

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Create a copy of the last 'amount' elements from the original list using GetRange.
    var endSlice = data.GetRange(data.Count - amount, amount);

    // Step 2: Create a copy of the remaining elements at the beginning of the list.
    var startSlice = data.GetRange(0, data.Count - amount);

    // Step 3: Clear the original list to prepare for inserting rotated values.
    data.Clear();

    // Step 4: Add the last 'amount' elements (from Step 1) to the beginning of the list.
    data.AddRange(endSlice);

    // Step 5: Add the beginning elements (from Step 2) after the end of the rotated list.
    data.AddRange(startSlice);
    }
}

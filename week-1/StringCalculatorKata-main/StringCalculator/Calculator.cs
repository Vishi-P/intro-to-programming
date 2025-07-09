
using System.ComponentModel.DataAnnotations;

public class Calculator
{
    public int Add(string numbers)
    {
        // Used for Steps 1 and 2, commented out during Step 3
        //return numbers == "" ? 0 : int.Parse(numbers);
        int length = numbers.Length;
        if (length == 0) return 0;
        else if (length == 1) return int.Parse(numbers);
        // Used for Step 3, commented out during Step 4
        //else if (length == 3)
        //{
        //    string[] arr = numbers.Split(",");
        //    return int.Parse(arr[0]) + int.Parse(arr[1]);
        //}
        else
        {
            int sum = 0;
            char[] delimiters = [',', '\n', '#'];
            string[] arr = numbers.Split(delimiters);
            for (int i = 0; i < arr.Length; i++)
            {
                sum += int.Parse(arr[i]);
            }
            return sum;
        }
    }
}

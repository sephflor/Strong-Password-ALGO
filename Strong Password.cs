using System;
using System.Linq;

class Result
{
    public static int minimumNumber(int n, string password)
    {
        int count = 0;

        
        if (!password.Any(char.IsDigit))
            count++;

        
        if (!password.Any(char.IsLower))
            count++;

        
        if (!password.Any(char.IsUpper))
            count++;

        
        string specialChars = "!@#$%^&*()-+";
        if (!password.Any(c => specialChars.Contains(c)))
            count++;

        
        int minLength = 6;
        int totalNeeded = Math.Max(count, minLength - n);

        return totalNeeded;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string password = Console.ReadLine().Trim();

        int result = Result.minimumNumber(n, password);
        Console.WriteLine(result);
    }
}

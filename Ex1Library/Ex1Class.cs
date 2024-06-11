using System.Text.RegularExpressions;

namespace ClassLibrary
{
  public class Ex1Class
  {

    public static bool IsPalindrome(string input)
    { 
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Input cannot be null or empty", nameof(input));
        }
        
        try
        {

            // removes all special characters, puntuation and spaces
            string stringCleaned = RemoveSpecialCharacters(input);

            int i = 0;
            int j = stringCleaned.Length - 1;
            while (true)
            {
                if (i > j)
                {
                    // overlapping indices indicates end of comparison - no early return, so return true
                    return true;
                }
                char a = stringCleaned[i];
                char b = stringCleaned[j];
                // toLower to ignore case
                if (char.ToLower(a) != char.ToLower(b))
                {
                    // return early on character mismatch
                    return false;
                }
                i++;
                j--;
            }
        }    
        catch (Exception e)
        {
            Console.WriteLine($"Error: An unexpected error occurred - {e.Message}");
            return false;
        }
        
    }

    private static string RemoveSpecialCharacters(string input)
    {
            // remove all characters that are not letters or digits (including spaces)
            Regex r = new Regex(@"[^\p{L}\p{Nd}]", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return r.Replace(input, string.Empty);
    }
  }
}





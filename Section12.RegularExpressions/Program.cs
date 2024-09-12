using System.Text.RegularExpressions;
using static System.Console;


namespace Section12.RegularExpressions
{
    public class Program
    {
        public static void Main()
        {
            string pattern = @"\d";
            Regex regex = new(pattern);
            string text = "Hi there, my number is 1234";
            MatchCollection matchCollection = regex.Matches(text);

            WriteLine($"{matchCollection.Count} hits found: \n {text}");

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                WriteLine($"{group[0].Value} found at {group[0].Index}.");
            }
        }
    }
}

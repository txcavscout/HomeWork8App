
using System.Text.RegularExpressions;

string inserts;

Console.Write("Enter a list of comma separated names: ");
inserts = Console.ReadLine();
string newNames = Regex.Replace(inserts, " *, *", ",");
List<string> names = newNames.Split(',').ToList();




for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"Hello {names[i]}");
}







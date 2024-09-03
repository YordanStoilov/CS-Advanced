
string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Func<string, bool> isUppercase = word => word[0] == word.ToUpper()[0];

string[] upperCase = words.Where(word => isUppercase(word)).ToArray();
upperCase.ToList().ForEach(word => Console.WriteLine(word));
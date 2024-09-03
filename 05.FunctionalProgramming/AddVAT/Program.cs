
Func<string, double> parse = x => double.Parse(x);
Func<double, double> addVat = x => x *= 1.2;

List<double> numsAsString = Console.ReadLine().Split(", ").Select(parse).
Select(addVat).ToList();

numsAsString.ForEach(num => Console.WriteLine($"{num:F2}"));

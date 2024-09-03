
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());

Func<int[], int[]> reverseArray = array => array.Reverse().ToArray();
Predicate<int> predicate = x => x % n != 0;
Action<int[]> PrintArray = array => Console.WriteLine(string.Join(" ", array));

nums = reverseArray(nums).Where(x => predicate(x)).ToArray();
PrintArray(nums);
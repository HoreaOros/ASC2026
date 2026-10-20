StreamReader reader = new StreamReader("input.txt");
string text= reader.ReadToEnd();
string[] lines = text.Split(Environment.NewLine);
List<int> nums;
int sum = 0;
foreach (string line in lines)
{
    nums = new List<int>();
    string[] tokens = line.Split(new char[] {' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < tokens.Length; i++)
        nums.Add(int.Parse(tokens[i]));
    sum += nums.Max() - nums.Min();
}
Console.WriteLine(sum);
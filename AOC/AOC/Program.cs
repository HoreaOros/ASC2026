StreamReader sr = new StreamReader("input.txt");
List<int> lst1 = new List<int>();
List<int> lst2 = new List<int>();
while (!sr.EndOfStream)
{
    string line = sr.ReadLine();
    // Process the line here
    string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    lst1.Add(int.Parse(parts[0]));
    lst2.Add(int.Parse(parts[1]));
}

lst1.Sort();
lst2.Sort();

// part1
int suma = 0;
for(int i = 0; i < lst1.Count; i++)
{
    suma += Math.Abs(lst1[i] - lst2[i]);
}   

Console.WriteLine(suma);


//part2
long suma1 = 0;
for(int i = 0; i < lst1.Count; i++)
{
    suma1 += lst1[i] * lst2.FindAll(x => x == lst1[i]).Count;
}

Console.WriteLine(suma1);
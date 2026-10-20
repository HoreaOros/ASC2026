
static int solve(string line, int offset)
{
    int suma = 0;
    for (int i = 0; i < line.Length; i++)
    {
        if (line[i] == line[(i + offset) % line.Length])
        {
            suma += int.Parse(line[i].ToString());
            //suma += line[i] - '0';
        }
    }
    return suma;
}


StreamReader sr = new StreamReader("input.txt");
string line = sr.ReadLine();
Console.WriteLine(solve(line, 1));
Console.WriteLine(solve(line, line.Length / 2));
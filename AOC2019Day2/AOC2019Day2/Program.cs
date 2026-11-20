StreamReader sr = new StreamReader("input.txt");
string input = sr.ReadToEnd();
sr.Close();

string[] tokens = input.Split(',');
int[] t = new int[tokens.Length];
for (int k = 0; k < t.Length; k++)
    t[k] = int.Parse(tokens[k]);


int[] t2 = new int[t.Length];
Array.Copy(t, t2, t.Length);
int ret = Part1(t2, 12, 2);
Console.WriteLine(ret);

for(int noun = 0;  noun <= 100; noun++)
    for(int verb = 0; verb <= 100; verb++)
    {
        Array.Copy(t, t2, t.Length);
        ret = Part1(t2, noun, verb);
        if(ret == 19690720)
        {
            Console.WriteLine(100 * noun + verb);
            break;
        }
    }

Console.WriteLine(t[0]);

static int Part1(int[] t, int noun, int verb)
{
    t[1] = noun; t[2] = verb;

    int i = 0;
    while (t[i] != 99)
    {
        if (t[i] == 1)
            t[t[i + 3]] = t[t[i + 1]] + t[t[i + 2]];
        else if (t[i] == 2)
            t[t[i + 3]] = t[t[i + 1]] * t[t[i + 2]];
        else
        {
            i++;
            continue;
        }
        i += 4;
    }
    return t[0];
}
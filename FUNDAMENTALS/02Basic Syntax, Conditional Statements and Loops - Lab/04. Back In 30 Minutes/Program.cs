int hourss = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());

min += 30;
if (min >= 60)
{
    hourss++;
    min -= 60;
}

if (hourss == 24)
{
    hourss = 0;
}

Console.WriteLine($"{hourss}:{min:d2}");

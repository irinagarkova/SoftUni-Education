﻿//"Error!"
//January, February, March, April, May, June, July, August, September, October, November, December
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1: Console.WriteLine("January"); break;
    case 2: Console.WriteLine("February"); break;
    case 3: Console.WriteLine("March"); break;
    case 4: Console.WriteLine("April"); break;
    case 5: Console.WriteLine("May"); break;
    case 6: Console.WriteLine("June"); break;
    case 7: Console.WriteLine("July"); break;
    case 8: Console.WriteLine("August"); break;
    case 9: Console.WriteLine("September"); break;
    case 10: Console.WriteLine("October"); break;
    case 11: Console.WriteLine("November"); break;
    case 12: Console.WriteLine("December"); break;
}
if (day < 1 || day > 13)
{
    Console.WriteLine("Error!");
}
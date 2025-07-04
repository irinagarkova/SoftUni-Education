// See https://aka.ms/new-console-template for more information

int nWagons = int.Parse(Console.ReadLine());
   
int sumOfPeople = 0;

int[] numbersOfPassengers = new int[nWagons];
for (int i = 0; i < nWagons; i++)
{
    int people = int.Parse(Console.ReadLine());
    numbersOfPassengers[i] = people;
    sumOfPeople += numbersOfPassengers[i];
}
Console.WriteLine(string.Join(" ",numbersOfPassengers));
Console.WriteLine(sumOfPeople);

using System.Collections.Generic;

Console.WriteLine("Enter a list of numbers, type 0 when finished.");

// create the list
List<decimal> numbers = new List<decimal>();
decimal number = -1;

//fills the list
while (number != 0)
{
    Console.Write("Enter number: ");
    number = decimal.Parse(Console.ReadLine());
    if (number != 0){
        numbers.Add(number);
    }
}

//find the sum of the contents of the list
decimal sum = 0;

for (int i = 0; i < numbers.Count; i++)
{
    sum += numbers[i];
}

//find average of the list
decimal avg = sum/numbers.Count; 

//find the largest number in the list
decimal biggest = 0;

for (int i = 0; i < numbers.Count; i++)
{
    if (biggest < numbers[i]) {
        biggest = numbers[i];
    }
}

Console.WriteLine("The sum is: " + sum);
Console.WriteLine("The average is: " + avg);
Console.WriteLine("The largest number is: " + biggest);
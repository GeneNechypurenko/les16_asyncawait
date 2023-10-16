
Random random = new Random();

int size = 20;
int[] array = new int[size];
for (int i = 0; i < size; i++) { array[i] = random.Next(10, 90); }



var allNumbers = from number
                 in array
                 select number;
Console.Write("array: ");
foreach (var number in allNumbers) { Console.Write($"{number} "); }
Console.WriteLine();



var evenNumbers = from number
                  in array
                  where number % 2 == 0
                  select number;
Console.Write("evens: ");
foreach (var number in evenNumbers) { Console.Write($"{number} "); }
Console.WriteLine();




var oddNumbers = from number
                 in array
                 where number % 2 != 0
                 select number;
Console.Write("odds: ");
foreach (var number in oddNumbers) { Console.Write($"{number} "); }
Console.WriteLine();




int pivot = 30;
var greatergThanPivot = from number
                        in array
                        where number > pivot
                        select number;
Console.Write($"greater than {pivot}: ");
foreach (var number in greatergThanPivot) { Console.Write($"{number} "); }
Console.WriteLine();





int minRange = 20;
int maxRange = 70;
var numbersInRange = from number
                     in array
                     where number >= minRange && number <= maxRange
                     select number;
Console.Write($"in range from {minRange} to {maxRange}: ");
foreach (var number in numbersInRange) { Console.Write($"{number} "); }
Console.WriteLine();





var multSeven = from number
                   in array
                where number % 7 == 0
                orderby number
                ascending
                select number;
Console.Write($"numbers that mult on 7: ");
foreach (var number in multSeven) { Console.Write($"{number} "); }
Console.WriteLine();






var multEight = from number
                   in array
                where number % 8 == 0
                orderby number
                descending
                select number;
Console.Write($"numbers that mult on 8: ");
foreach (var number in multEight) { Console.Write($"{number} "); }
Console.WriteLine();
// The Three Parts of a LINQ Query
// 1. Data Source.
int[] numbers = [0, 1, 2, 3, 4, 5, 6,];

// 2. Query Creation.
// numQuery is an IEnumerable<int>
var numQuery = from num in numbers
               where (num % 2) == 0
               select num;

// 3. Query execution.
foreach (int num in numQuery)
{
    Console.Write("{0, 1} ", num);
}

// Immediate execution
var evenNumQuery = from num in numbers
                   where (num % 2) == 0
                   select num;

// store a count of the even number result
var evenNumCount = evenNumQuery.Count();

// Store the result of a query in  memory
List<int> numbers1 = [1, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20];

IEnumerable<int> queryFactorsOfFour = from num in numbers1
                                      where (num % 4) == 0
                                      select num;

// Store the result in a new variable 
// Without executing a foreach loop
var factorsOfFourList = queryFactorsOfFour.ToList();

// Read and write from the newly created list to demonstrate that it holds data.
Console.WriteLine(factorsOfFourList[2]);
factorsOfFourList[2] = 0;
Console.WriteLine(factorsOfFourList[2]);
List<int> numbers1 = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
List<int> numbers2 = [15, 14, 11, 13, 19, 18, 16, 17, 12, 10];

// Query #4.
var average = numbers1.Average();

// Query #5.
var concatenationQuery =
    numbers1.OrderBy(n => n)
    .Concat(numbers2.OrderBy(n => n));

// Query #6.
var largeNumberQuery =
    numbers2.Where(c => c > 15)
    .OrderBy(a => a);

foreach (var number in concatenationQuery)
{
    Console.Write("{0, 1} ", number);
}

// Query #7.

// Using a query expression with method syntax
var numCount1 = (
    from num in numbers1
    where num is > 3 and < 7
    select num
).Count();

// Better: Create a new variable to store
// the method call result
var numbersQuery =
    from num in numbers1
    where num is > 3 and < 7
    select num;

var numCount2 = numbersQuery.Count();

// in method syntax
var numCount = numbers1.Count(n => n is > 3 and < 7);
List<int> numbers = [ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 ];

// The query variables can also be implicitly typed by using var

// Query #1.
var filteringQuery =
    from num in numbers
    where num is < 3 or > 7
    select num;

// Query #2.
var orderingQuery =
    from num in numbers
    where num is < 3 or > 7
    orderby num ascending
    select num;

// Query #3.
string[] groupingQuery = ["carrots", "cabbage", "broccoli", "beans", "barley"];
var queryFoodGroup = groupingQuery.GroupBy(x => x[0]);
IEnumerable<IGrouping<char, string>> queryFoodGroups =
    from item in groupingQuery
    group item by item[0];

foreach (var group in queryFoodGroups)
{
    Console.Write(group.Key);
    foreach (var elm in group)
    {
        Console.WriteLine(elm);
    }
}
// Covariance: Allow assign more specific type to more general type:
using System.Numerics;

IEnumerable<string> strings = new List<string>();
IEnumerable<object> objects = strings; // Covariance: string is more specific type than object

// Contravariance: Allow assign more general type to more specific type:
Action<object> handleObject = obj => Console.WriteLine(obj);
Action<string> handleString = handleObject; // Contravariance: object is more general type than string

// Generic math and methods
static T Add<T>(T left, T right) where T : INumber<T>
{
    return left + right;
}

int result = Add(5, 10); // Works with interger
double resultDouble = Add(5.5, 10.2); // Works with doubles
Console.WriteLine(result);
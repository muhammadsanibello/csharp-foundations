using Exercise_06_Animal_Class;

// A list of Animal objects
var animals = new List<Animal>
{
    new() { Name = "Dog", Age = 2, Sound = "Bark" },
    new() { Name = "Cat", Age = 2, Sound = "Meow" },
    new() { Name = "Fox", Age = 5, Sound = "Bark" }
};

// A list of Person objects
var people = new List<Person>
{
    new() { Name = "Harry Potter", Address = "123 Privet Drive, Hogwarts, United Kingdom", Age = 26 },
    new() { Name = "Alex the kidd", Address = "Rock Paper Scissors Avenue, United Kingdom", Age = 35 },
    new() { Name = "Donkey Kong", Address = "The Monkey Temple, Jungle", Age = 35 }
};

// Query the barking animals from the list of Animals
// using query syntax.
var barkingAnimals =
    from animal in animals
    where animal.Sound == "Bark"
    select animal;

// Using method syntax
var barkingAnimals1 = animals.Where(animal => animal.Sound == "Bark");

// Ordering elemets based on their age
var orderedByAge = animals.OrderBy(x => x.Age);
var orderedByAgeDescending = animals.OrderByDescending(x => x.Age);

// Using First Method
var first = animals.First(x => x.Sound == "Bark");

// Using Single and SingleOrDefault Method
var cat = animals.Single(x => x.Name == "Cat");
var cat1 = animals.SingleOrDefault(x => x.Name == "Cat");

if (cat1 != null)
{
    Console.WriteLine("A single cat was found");
}

// Using Select method
var typesOfAnimal = animals.Select(x => x.Name).ToList();

// Returning name and sound of objets
var anonymousAnimals = animals.Select(x => new { Name = x.Name, Noise = x.Sound}).ToList();

// Find all the people in the list whose address contains "United Kingdom"
var ukResidents = people.Where(x => x.Address.Contains("United Kingdom")).ToList();

// Call Harry Potter in the People list
var PeopleCalledHarryPotter = people.Where(x => x.Name == "Harry Potter");

// Chaining IQuerable API Methods
var groupsOfPeople = people
    .Where(p => p.Age >= 30)  // Filter people with age >= 30
    .GroupBy(p => p.Age);     // Group people by their age

foreach (var group in groupsOfPeople)
{
    Console.WriteLine($"Age Group: {group.Key}"); // Output the Age
    foreach (var person in group)
    {
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}
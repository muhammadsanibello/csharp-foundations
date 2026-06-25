using System.Text;

class Employee
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Occupation { get; set; }

    public override string ToString()
    {
        return $"{Name},{Age},{Occupation}";
    }
}

class Program
{
    static void Main()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string folderPath = Path.Combine(desktopPath, "InventoryData");

        string filePath = Path.Combine(folderPath, "data_with_header.csv");

        // Create a list of employees
        List<Employee> employees = new()
        {
            new Employee { Name = "Elize Harmsen", Age = 30, Occupation = "Engineer" },
            new Employee { Name = "Peter Zammit", Age = 25, Occupation = "Designer" },
            new Employee { Name = "Niki Demetriou", Age = 35, Occupation = "Manager" }
        };

        // Write employees to a CSV file with a header
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name,Age,Occupation"); // Write the header

            foreach (var employee in employees)
            {
                sb.AppendLine(employee.ToString()); // Write each employee as a CSV row
            }

            writer.Write(sb.ToString());
        }

        // Append additional employees to the CSV file without a header
        List<Employee> additionalEmploees = new()
        {
            new Employee { Name = "Hannah Haynes", Age = 28, Occupation = "Developer" },
            new Employee { Name = "Conrad Nuber", Age = 32, Occupation = "Analyst" }
        };

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            StringBuilder sb = new StringBuilder();

            foreach (var employee in additionalEmploees)
            {
                sb.AppendLine(employee.ToString()); // Append each employee as a CSV row
            }

            writer.Write(sb.ToString());
        }

        // Create a list to hold employees read from the CSV file
        List<Employee> readEmployees = new();

        // Read the CSV file and create Employee objects
        using (StreamReader reader = new(filePath))
        {
            string? headerLine = reader.ReadLine(); // Read the header line
            Console.WriteLine($"Header {headerLine}");

            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(",");

                Employee employee = new Employee
                {
                    Name = data[0],
                    Age = int.Parse(data[1]),
                    Occupation = data[2]
                };

                readEmployees.Add(employee);
            }
        }

        // Display the list of employees
        foreach (var employee in readEmployees)
        {
            Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Occupation: {employee.Occupation}");
        }
    }
}
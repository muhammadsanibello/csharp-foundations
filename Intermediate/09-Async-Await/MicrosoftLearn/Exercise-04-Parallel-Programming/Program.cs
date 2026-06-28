// Code that demonstrates how to use 'Task.WhenAll' to run multiple tasks in parallel and wait for their completion

class Program
{
    static async Task Main(string[] args)
    {
        var urls = new List<string>
        {
            "https://example.com",
            "https://example.org",
            "https://example.net"
        };

        var tasks = new List<Task<string>>();

        foreach (var url in urls)
        {
            tasks.Add(FetchDataAsync(url));
        }

        // Wait for all tasks to complete
        var results = await Task.WhenAll(tasks);

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }

    static async Task<string> FetchDataAsync(string url)
    {
        using (var client = new HttpClient())
        {
            return await client.GetStringAsync(url);
        }
    }
}
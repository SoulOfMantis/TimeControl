using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TimeTrackerClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string serverUrl = "http://timeserver:5000";

        static async Task Main(string[] args)
        {
            Console.WriteLine("Time Tracker Client started...");
            Console.WriteLine("Press Ctrl+C to stop\n");

            while (true)
            {
                try
                {
                    await GetProductivityStats();
                    await GetTasks();

                    Console.WriteLine($"Last update: {DateTime.Now:HH:mm:ss}");
                    Console.WriteLine(new string('-', 50));

                    await Task.Delay(10000); // 10 секунд
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine("Retrying in 10 seconds...");
                    await Task.Delay(10000);
                }
            }
        }

        static async Task GetProductivityStats()
        {
            var response = await client.GetStringAsync($"{serverUrl}/api/productivity");
            var stats = JsonSerializer.Deserialize<ProductivityStats>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            Console.WriteLine($"\n📊 Productivity Statistics for {stats.Date}:");
            Console.WriteLine($"   Work: {stats.WorkTime} minutes");
            Console.WriteLine($"   Break: {stats.BreakTime} minutes");
            Console.WriteLine($"   Entertainment: {stats.EntertainmentTime} minutes");
            Console.WriteLine($"   Active apps: {string.Join(", ", stats.ActiveApplications)}");
        }

        static async Task GetTasks()
        {
            var response = await client.GetStringAsync($"{serverUrl}/api/tasks");
            var tasks = JsonSerializer.Deserialize<TaskItem[]>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            Console.WriteLine($"\n📝 Tasks:");
            foreach (var task in tasks)
            {
                var status = task.Completed ? "✅" : "⏳";
                Console.WriteLine($"   {status} {task.Name}");
            }
        }
    }

    public class ProductivityStats
    {
        public string Date { get; set; }
        public int WorkTime { get; set; }
        public int BreakTime { get; set; }
        public int EntertainmentTime { get; set; }
        public string[] ActiveApplications { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
    }
}

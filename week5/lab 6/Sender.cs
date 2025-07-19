using Confluent.Kafka;
class Sender
{
    static async Task Main(string[] args)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };
        using var sender = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Type a message :");

        while (true)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) continue;
            if (input.ToLower() == "exit") break;

            var result = await sender.ProduceAsync("chat-topic", new Message<Null, string> { Value = input });
            Console.WriteLine($"Sent: {result.Value}");
        }
    }
}

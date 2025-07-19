using Confluent.Kafka;
class Receiver
{
    static void Main(string[] args)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "chat-consumer-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };
        using var receiver = new ConsumerBuilder<Ignore, string>(config).Build();
        receiver.Subscribe("chat-topic");
        Console.WriteLine("Listening for messages....");
        while (true)
        {
            var consumeResult = receiver.Consume();
            Console.WriteLine($"Received: {consumeResult.Message.Value}");
        }
    }
}

using Kafka.Consumer.Handler.Handler;
using System.Threading;

namespace Kafka.Consumer.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageHandler message = new MessageHandler();
            message.StartAsync(CancellationToken.None);
        }
    }
}

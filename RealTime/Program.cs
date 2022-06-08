using System;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Producer;

namespace MissedCalls
{
    /* 
     Console App that pushes sample data to an Event Hub in real-time. This is intended to be used to demo or evaluate Power BI's real-time reporting capabilities.
     */
    class Program
    {
        // TODO: connection string to the Event Hubs namespace
        private const string connectionString = "{myeventhubconnectionstring}"; 

        // TODO: name of the event hub
        private const string eventHubName = "{myEventHubName}";

        // number of events to be sent to the event hub
        private const int numOfEvents = 1;
        private const int lagMilliseconds = 2000;

        private static string[] callTypes = new string[2] { "101", "999" };
        private static string[] callStatuses = new string[3] { "unanswered", "unintelligible", "dropped by caller" };

        // The Event Hubs client types are safe to cache and use as a singleton for the lifetime
        // of the application, which is best practice when events are being published or read regularly.
        static EventHubProducerClient producerClient;

        static async Task Main()
        {
            // Create a producer client that you can use to send events to an event hub
            producerClient = new EventHubProducerClient(connectionString, eventHubName);

            Random rand1 = new();
            Random rand2 = new();
            Random rand3 = new();

            while (!Console.KeyAvailable)
            {
                // Create a batch of events 
                using EventDataBatch eventBatch = await producerClient.CreateBatchAsync();

                for (int i = 1; i <= numOfEvents; i++)
                {
                    var callType = callTypes[rand1.Next(callTypes.Length)];
                    var callStatus = callStatuses[rand2.Next(callStatuses.Length)];
                    var callDurationSeconds = rand3.Next(15, 90);
                    DateTime endTime = DateTime.Now.ToLocalTime();
                    var receivedTime = endTime.AddSeconds(-callDurationSeconds);


                    var call = new Call()
                    {
                        CallType = callType
                        ,
                        Status = callStatus
                        ,
                        CallDurationSeconds = callDurationSeconds
                        ,
                        EndTime = endTime
                        ,
                        Receivedtime = receivedTime
                    };

                    var callJson = JsonSerializer.Serialize(call, typeof(Call));

                    Console.WriteLine(callJson);

                    if (!eventBatch.TryAdd(new EventData(Encoding.UTF8.GetBytes(callJson))))
                    {
                        // if it is too large for the batch
                        throw new Exception($"Event {i} is too large for the batch and cannot be sent.");
                    }
                }

                 // Use the producer client to send the batch of events to the event hub
                    await producerClient.SendAsync(eventBatch);
                    Console.WriteLine($"A batch of {numOfEvents} events has been published.");
                    Thread.Sleep(lagMilliseconds);
            }
             
            await producerClient.DisposeAsync();
        }
    }

    class Call
    {
        public string CallType { get; set; }

        public string Status { get; set; }

        public DateTime EndTime { get; set; }

        public int CallDurationSeconds { get; set; }

        public DateTime Receivedtime { get; set; }

    }
}

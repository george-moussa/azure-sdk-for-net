using System;
using System.Threading;
using Azure.Quantum;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            QuantumJobsClient client = new QuantumJobsClient("<subId>", "sdk-review-rg", "workspace-ms", "westus");
            var jobs = client.ListJobs(CancellationToken.None).Result;

            Console.WriteLine(JsonConvert.SerializeObject(jobs));
        }
    }
}

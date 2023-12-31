using System;
using System.IO;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class BlobTrigger1
    {
        private readonly ILogger _logger;

        public BlobTrigger1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<BlobTrigger1>();
        }

        [Function("BlobTrigger1")]
        public void Run([BlobTrigger("input-images/{name}", Connection = "storeageblobtriggered_STORAGE")] string myBlob, string name)
        {
            _logger.LogInformation($"C# Blob trigger function Processed blob\n Name: {name}");
        }
    }
}

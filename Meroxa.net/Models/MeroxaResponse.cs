using System;
namespace Meroxa.net.helpers.Models
{
    public class MeroxaResponse
    {

        public bool IsSuccessful { get; set; }

        public string message { get; set; }
        
        public data data { get; set; }

    }

    public class data
    {
        public string Metadata { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppCalculatorAzure.Models
{
    internal class Result
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Answer { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }
    }
}

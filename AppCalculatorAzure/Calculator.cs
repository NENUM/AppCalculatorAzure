using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AppCalculatorAzure.Models;
using AppCalculatorAzure.Methods;

namespace AppCalculatorAzure
{
    public static class Calculator
    {
        [FunctionName("Calculator")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("App calculator in an Azure function");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            Logic logic = new Logic();
            Result result = new Result();
            Operation data;

            try
            {
                data = JsonConvert.DeserializeObject<Operation>(requestBody);
            }catch(Exception e)
            {
                result.Error = "Parsing error JSON";
                return new OkObjectResult(result);
            }
            
            
            result = logic.MultipleOperations(data);
            log.LogInformation(result.Answer.ToString());
            log.LogInformation(result.Error);


            return new OkObjectResult(result);
        }
    }
}

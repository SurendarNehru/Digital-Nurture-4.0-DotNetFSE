using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiLab3and4.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            File.AppendAllText("error_log.txt", $"{DateTime.Now}: {context.Exception.Message}\n");
            context.Result = new ObjectResult("An error occurred")
            {
                StatusCode = 500
            };
        }
    }
}

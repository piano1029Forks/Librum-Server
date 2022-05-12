using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Application.Common.DTOs;

public class ApiExceptionDto
{
    public int StatusCode { get; set; }

    public string Message { get; set; }

    public string StackTrace { get; set; }


    public ApiExceptionDto(int statusCode, string message, string stackTrace = null)
    {
        StatusCode = statusCode;
        Message = message;
        StackTrace = stackTrace;
    }

    public override string ToString() => JsonConvert.SerializeObject(this, new JsonSerializerSettings());
}
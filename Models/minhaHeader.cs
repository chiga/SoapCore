using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using SoapCore.Extensibility;
using SoapCore.ServiceModel;

namespace prjSoapCore.Models
{
    public class minhaHeader: IServiceOperationTuner
    {
        public void Tune(HttpContext httpContext, object serviceInstance, OperationDescription operation)
        {
            if (operation.Name.Equals("SomeOperationName"))
            {
                SampleService service = serviceInstance as SampleService;
                string result = string.Empty;

                StringValues paramValue;
                if (httpContext.Request.Headers.TryGetValue("some_parameter", out paramValue))
                {
                    result = paramValue[0];
                }

                //service.SetParameterForSomeOperation(result);
            }
        }
    }
}
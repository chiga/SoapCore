using System.Threading;

namespace prjSoapCore.Models
{
    public class SampleService : ISampleService
    {
        // Use ThreadLocal or some of thread sinchronization stuff if service registered as singleton.
        private ThreadLocal<string> _paramValue = new ThreadLocal<string>() { Value = string.Empty };

    
        public void SetParameterForSomeOperation(string paramValue)
        {
            _paramValue.Value = paramValue;
        }

    public string SomeOperationName()
    {
        return "Param value from http header: " + _paramValue.Value;
    }
        public meuModelo Modelo(meuModelo inpuModelo)
        {
            return inpuModelo;
        }
    }
}
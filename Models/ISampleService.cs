using System.ServiceModel;

namespace prjSoapCore.Models
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        meuModelo Modelo(meuModelo inpuModelo);
        
    }
}
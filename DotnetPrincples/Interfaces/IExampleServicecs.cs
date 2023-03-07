using DotnetPrincples.Models;

namespace DotnetPrincples.Interfaces
{
    public interface IExampleServicecs
    {
        Task<IReturnValue> GetReturnValue();
        Task<string> Convert(SampleReturnB sample);
    }
}

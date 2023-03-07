using DotnetPrincples.Interfaces;
using DotnetPrincples.Models;

namespace DotnetPrincples.Services
{
    public class ExampleService:IExampleServicecs
    {
        public async Task<IReturnValue> GetReturnValue()
        {
            try
            {
                if(1 != 1)
                {
                    return new SampleReturnA
                    { 
                        address = "abcd",
                        age = 12,
                        name = "addition",
                        newAddition = "one"
                    };
                }
                else
                {
                    return new SampleReturnB
                    {
                        address = "abcd",
                        age = 12,
                        name = "addition"
                    };
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<string> Convert(SampleReturnB sample)
        {
            try
            {
                if(sample !=null)
                {
                    return sample.address;
                }
            }
            catch (Exception ex)
            {
                
            }
            return null;
        }
    }
}

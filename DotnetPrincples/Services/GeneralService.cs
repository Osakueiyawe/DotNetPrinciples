using DotnetPrincples.Interfaces;

namespace DotnetPrincples.Services
{
    public class GeneralService:IGeneralService
    {
        private readonly IExampleServicecs _exampleServices;
        public GeneralService(IExampleServicecs exampleServicecs) 
        { 
            _exampleServices= exampleServicecs;
        }
        public async Task<IReturnValue> TestExampleService()
        {
            IReturnValue returnValue = await _exampleServices.GetReturnValue();
            return returnValue;
        }

        public async Task<IReturnValue> TestFuncFunctionality()
        {
            Func<Task<IReturnValue>> getReturnVal = async() => await TestExampleService();
            IReturnValue retVal = await getReturnVal();
            return retVal;
        }
    }
}

using DotnetPrincples.Interfaces;

namespace DotnetPrincples.Services
{
    public class Task:IGeneric<Task>
    {
        public async Task<int> Add(int a, int b)
        {
            return 2*a + b;
        }
    }
}

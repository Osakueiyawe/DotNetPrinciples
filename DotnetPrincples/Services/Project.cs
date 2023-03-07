using DotnetPrincples.Interfaces;

namespace DotnetPrincples.Services
{
    public class Project:IGeneric<Project>
    {
        public async Task<int> Add(int a, int b)
        {
            var testList = new List<int>();
            var testList1 = new List<int>() { a,b,5,7};
            Parallel.ForEach(testList1, a=>testList.Add(a));
            return testList[0];
        }
    }
}

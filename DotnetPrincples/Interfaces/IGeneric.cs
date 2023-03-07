namespace DotnetPrincples.Interfaces
{
    public interface IGeneric<T>
    {
        Task<int> Add(int a, int b);
    }
}

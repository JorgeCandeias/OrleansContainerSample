using Orleans;
using System.Threading.Tasks;

namespace Grains.Interfaces
{
    public interface ICounterGrain : IGrainWithGuidKey
    {
        Task IncrementAsync();

        Task<int> GetValueAsync();
    }
}
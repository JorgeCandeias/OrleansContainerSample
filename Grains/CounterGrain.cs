using Grains.Interfaces;
using Orleans;
using System.Threading.Tasks;

namespace Grains
{
    public class CounterGrain : Grain, ICounterGrain
    {
        private int counter;

        public Task<int> GetValueAsync() => Task.FromResult(counter);

        public Task IncrementAsync()
        {
            ++counter;
            return Task.CompletedTask;
        }
    }
}
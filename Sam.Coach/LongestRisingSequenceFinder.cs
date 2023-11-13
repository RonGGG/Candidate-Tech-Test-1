using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Sam.Coach.Tests")]
namespace Sam.Coach
{
    internal class LongestRisingSequenceFinder : ILongestRisingSequenceFinder
    {
        public Task<IEnumerable<int>> Find(IEnumerable<int> numbers) => Task.Run(() =>
        {
            var numList = numbers.ToList();

            if (!numList.Any()) return Enumerable.Empty<int>();

            int maxLength = 1;
            int currentLength = 1;
            int endIndex = 0;
            int endFinal = 0;

            for (int i = 1; i < numList.Count; i++)
            {
                if (numList[i] > numList[i - 1])
                {
                    currentLength++;
                    endIndex = i;

                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        endFinal = endIndex;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            var longestSequence = new List<int>();
            for (int i =  endFinal - maxLength +1; i<=endFinal; i++) {
                longestSequence.Add(numList[i]);
            }
            return longestSequence;
        });

    }
}

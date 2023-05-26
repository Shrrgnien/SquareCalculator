using System.Collections;

namespace SquareCalculator.Tests.TestData;

public class CircleTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 1, 3.141593 };
        yield return new object[] { 2, 12.566371 };
        yield return new object[] { 7, 153.93804 };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

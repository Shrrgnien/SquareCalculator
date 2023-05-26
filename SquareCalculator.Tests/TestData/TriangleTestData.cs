using System.Collections;

namespace SquareCalculator.Tests.TestData;

public class TriangleTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 1, 2, 2, 0.968246 };
        yield return new object[] { 7, 10, 15, 29.393877 };
        yield return new object[] { 3, 3, 3, 3.897114 };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

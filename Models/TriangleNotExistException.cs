using System.Runtime.Serialization;

namespace SquareCalculator.Models
{
    [Serializable]
    public class TriangleNotExistException : Exception
    {
        public TriangleNotExistException()
        {
        }

        public TriangleNotExistException(string? message = "Triangle with provided edges doesn't exist") : base(message)
        {
        }

        public TriangleNotExistException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public TriangleNotExistException(double a, double b, double c) : base($"Triangle {a}, {b}, {c} doesn't exist")
        {
        }
        protected TriangleNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
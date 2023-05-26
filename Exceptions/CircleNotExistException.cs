using System.Runtime.Serialization;

namespace SquareCalculator.Exceptions
{
    [Serializable]
    public class CircleNotExistException : Exception
    {
        public CircleNotExistException()
        {
        }

        public CircleNotExistException(string? message = "Circle with provided radius doesn't exist") : base(message)
        {
        }

        public CircleNotExistException(double radius) : base($"Circle with radius {radius} doesn't exist")
        {
        }

        public CircleNotExistException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CircleNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
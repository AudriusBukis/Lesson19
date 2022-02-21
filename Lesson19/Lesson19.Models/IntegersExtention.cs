
namespace Lesson19.Models
{
    public static class IntegersExtention
    {
        public static bool PositiveNumber(this int number) => number >= 0;
        public static bool EvenNumber(this int number) => (number % 2 == 0);
        public static bool BigerNumberThenThis(this int number, int inputNubber) => number > inputNubber;
    }
}

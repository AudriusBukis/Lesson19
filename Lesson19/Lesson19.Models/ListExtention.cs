using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson19.Models
{
    public static class ListExtention
    {
        public static T FindAndReturnIfEqual<T>(this List<T> type, T elementToFind)
        {
            try
            {
                return type.FirstOrDefault(x => x.Equals(elementToFind));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"error in {nameof(type)}: Mesage - {ex}");
                return default;
            }
        }
        public static List<T> EveryOtherWord<T>(this List<T> list)
        {
            return list.Where((line, index) => index % 2 == 0).ToList();
        }
    }
}

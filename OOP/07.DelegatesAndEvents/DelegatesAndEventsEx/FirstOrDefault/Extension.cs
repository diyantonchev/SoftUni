using System;
using System.Collections.Generic;

public static class Extension
{
    public static T FirstOrDefault<T>(this IEnumerable<T> collection, Predicate<T> condition)
    {
        foreach (var element in collection)
        {
            bool isTrue = condition(element);
            if (isTrue)
            {
                return element;
            }
        }
        return default(T);
    }

    public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        var result = new List<T>();
        foreach (var element in collection)
        {
            if (predicate(element))
            {
                result.Add(element);
            }
        }
        return result;
    }

    public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
    {
        foreach (var element in collection)
        {
            action(element);
        }
    }
}
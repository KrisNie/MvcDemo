using System;

namespace Collections.DataStructure.Common;

public static class Comparers
{
    /// <summary>
    /// Determines if a specific value is a number.
    /// </summary>
    /// <returns><c>true</c> if the value is a number; otherwise, <c>false</c>.</returns>
    /// <param name="value">Value.</param>
    /// <typeparam name="T">The Type of value.</typeparam>
    public static bool IsNumber<T>(this T value)
    {
        return value switch
        {
            sbyte or byte or short or ushort or int or uint or long or ulong or float or double
                or decimal => true,
            _ => false
        };
    }

    public static bool IsEqualTo<T>(this T firstValue, T secondValue) where T : IComparable<T>
    {
        return firstValue.Equals(secondValue);
    }

    public static bool IsGreaterThan<T>(this T firstValue, T secondValue) where T : IComparable<T>
    {
        return firstValue.CompareTo(secondValue) > 0;
    }

    public static bool IsLessThan<T>(this T firstValue, T secondValue) where T : IComparable<T>
    {
        return firstValue.CompareTo(secondValue) < 0;
    }

    public static bool IsGreaterThanOrEqualTo<T>(this T firstValue, T secondValue)
        where T : IComparable<T>
    {
        return (firstValue.IsEqualTo(secondValue) || firstValue.IsGreaterThan(secondValue));
    }

    public static bool IsLessThanOrEqualTo<T>(this T firstValue, T secondValue)
        where T : IComparable<T>
    {
        return (firstValue.IsEqualTo(secondValue) || firstValue.IsLessThan(secondValue));
    }
}
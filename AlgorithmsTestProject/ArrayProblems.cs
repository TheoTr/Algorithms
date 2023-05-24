using System.Xml.Linq;

namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        if(xs.Length != ys.Length) return false;
        else 
            for (var i= 0; i < (xs.Length-1); i ++)
                if (!xs[i].Equals(ys[i]))return false;
        return true;
    }

    public static void Swap<T>(T[] xs, int a, int b)
    {
        T temp = xs[a];
        xs[a] = xs[b];
        xs[b] = temp;

    }

    public static T FirstElement<T>(T[] xs)
    {
        return xs[0];
    }

    public static T LastElement<T>(T[] xs)
    {
        return xs[xs.Length-1];
    }

    public static T MiddleElement<T>(T[] xs)
    {
        return xs[(xs.Length/2)];
    }

    public static void Reverse<T>(T[] xs)
    {
        var temp = new T[xs.Length];
        for (var i = 0; i < xs.Length; i++)
            temp[i] = xs[xs.Length - 1 - i];

        Array.Copy(temp, xs, xs.Length);
    }

    public static int CountElement<T>(T[] xs, T element)
    {
        int count = 0;
        for (int i = 0; i < xs.Length; i++)
        {
            if (EqualityComparer<T>.Default.Equals(xs[i], element))
            {
                count++;
            }
        }
        return count;

    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        throw new NotImplementedException();
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        var minIndex = 0;
        for (var i = 1; i < xs.Length; i++)
        {
            if (comparer(xs[i], xs[minIndex]) < 0)
            {
                minIndex = i;
            }
        }
        return xs[minIndex];
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        var max = 0;
        for (var i = 0; i < xs.Length; ++i)
        {
            if (xs[i] >= max)
            {
                max = i;
            }
           
        }
        return max
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        throw new NotImplementedException();
    }
}
using System;


namespace ListManagementProject
{
    public static class Test<T> where T : IComparable
    {
        public static  long TestDurationPush(OrderedList<T> list,T item)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            list.Push(item);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }
        public static long TestDurationPop(OrderedList<T> list)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            list.Pop();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }
    }
}

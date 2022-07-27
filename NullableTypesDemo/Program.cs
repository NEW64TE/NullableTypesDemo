using System;

namespace NullableTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;

            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            Console.WriteLine("Value: " + date.Value);

        }
    }
}

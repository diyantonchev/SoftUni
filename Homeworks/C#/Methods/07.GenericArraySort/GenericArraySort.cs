using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class GenericArraySort
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().ToList().ToList();

            List<int> numbers = new List<int> { 15, 23, 16, 8, 42, 4 };
            List<string> strings = new List<string> { "azis", "em", "zaz", "gaz", "cba", "baa", "4uk" };
            List<DateTime> dates = new List<DateTime>
            {
              new DateTime(2015, 04, 12),
              new DateTime(2014, 08, 05), 
              new DateTime(1890, 09, 02) 
            };
            
            SortArray(array);
            Console.WriteLine();
            SortArray(numbers);
            Console.WriteLine();
            SortArray(strings);
            Console.WriteLine();
            SortArray(dates);
           
        }
        static void SortArray<T> (List<T> list)
        {
            list.Sort();  // sorry :)
 
            //int temp = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    for (int j = 0; j < list.Count - 1; j++)
            //    {
            //        if (list[j] > list[j + 1])
            //        {
            //            temp = list[j + 1];
            //            list[j + 1] = list[j];
            //            list[j] = temp;
            //        }
            //    }
            //}
            Console.WriteLine(string.Join(", ", list));
        }
    }

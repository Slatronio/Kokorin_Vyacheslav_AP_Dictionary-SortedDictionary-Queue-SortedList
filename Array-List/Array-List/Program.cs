﻿using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{

    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        SortedDictionary<string, string> sort_dict = new SortedDictionary<string, string>();
        Queue<string> queue = new Queue<string>();
        SortedList<string, string> sort_list = new SortedList<string, string>();
        string[] arrcopy;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Dictionary");
            Console.WriteLine("1. Add" + '\n' +
            "2. Clear" + '\n' +
            "3. CopyTo" + '\n' +
            "4. ContainsValue" + '\n' +
            "5. ContainsKey" + '\n' +
            "6. GetHashCode" + '\n' +
            "7. Remove" + '\n' +
            "8. GetType" + '\n' +
            "9. ToString" + '\n' +
            "10. Equals");
            Console.WriteLine("SortedDictionary");
            Console.WriteLine("11. Add" + '\n' +
            "12. Clear" + '\n' +
            "13. CopyTo" + '\n' +
            "14. ContainsValue" + '\n' +
            "15. ContainsKey" + '\n' +
            "16. GetHashCode" + '\n' +
            "17. Remove" + '\n' +
            "18. GetType" + '\n' +
            "19. ToString" + '\n' +
            "20. Equals");
            Console.WriteLine("Queue");
            Console.WriteLine("21. Enqueue" + '\n' +
            "22. Clear" + '\n' +
            "23. CopyTo" + '\n' +
            "24. Contains" + '\n' +
            "25. Peek" + '\n' +
            "26. GetHashCode" + '\n' +
            "27. Dequeue" + '\n' +
            "28. GetType" + '\n' +
            "29. ToString" + '\n' +
            "30. Equals");
            Console.WriteLine("SortedList");
            Console.WriteLine("31. Add" + '\n' +
            "32. Clear" + '\n' +
            "33. CopyTo" + '\n' +
            "34. ContainsValue" + '\n' +
            "35. ContainsKey" + '\n' +
            "36. GetHashCode" + '\n' +
            "37. Remove" + '\n' +
            "38. GetType" + '\n' +
            "39. ToString" + '\n' +
            "40. Equals");
            Console.WriteLine("41. Break");

            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (n == 1)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                dict.Add(key, value);
            }
            if (n == 2)
            {
                dict.Clear();
            }
            if (n == 3)
            {
                arrcopy = new string[dict.Count];
                dict.Values.CopyTo(arrcopy, dict.Count);
            }
            if (n == 4)
            {
                string value = Console.ReadLine();
                Console.WriteLine(dict.ContainsValue(value));
                Console.ReadLine();
            }
            if (n == 5)
            {
                string key = Console.ReadLine();
                Console.WriteLine(dict.ContainsKey(key));
                Console.ReadLine();
            }
            if (n == 6)
            {
                Console.WriteLine(dict.GetHashCode());
                Console.ReadLine();
            }
            if (n == 7)
            {
                string key = Console.ReadLine();
                dict.Remove(key);
            }
            if (n == 8)
            {
                Console.WriteLine(dict.GetType());
                Console.ReadLine();
            }
            if (n == 9)
            {
                Console.WriteLine(dict.ToString());
                Console.ReadLine();
            }
            if (n == 10)
            {
                Console.WriteLine(dict.Equals(dict));
                Console.ReadLine();
            }

            if (n == 11)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                sort_dict.Add(key, value);
            }
            if (n == 12)
            {
                sort_dict.Clear();
            }
            if (n == 13)
            {
                arrcopy = new string[sort_dict.Count];
                sort_dict.Values.CopyTo(arrcopy, sort_dict.Count);
            }
            if (n == 14)
            {
                string value = Console.ReadLine();
                Console.WriteLine(sort_dict.ContainsValue(value));
                Console.ReadLine();
            }
            if (n == 15)
            {
                string key = Console.ReadLine();
                Console.WriteLine(sort_dict.ContainsKey(key));
                Console.ReadLine();
            }
            if (n == 16)
            {
                Console.WriteLine(sort_dict.GetHashCode());
                Console.ReadLine();
            }
            if (n == 17)
            {
                string key = Console.ReadLine();
                sort_dict.Remove(key);
            }
            if (n == 18)
            {
                Console.WriteLine(sort_dict.GetType());
                Console.ReadLine();
            }
            if (n == 19)
            {
                Console.WriteLine(sort_dict.ToString());
                Console.ReadLine();
            }
            if (n == 20)
            {
                Console.WriteLine(sort_dict.Equals(sort_dict));
                Console.ReadLine();
            }

            if (n == 21)
            {
                string value = Console.ReadLine();
                queue.Enqueue(value);
            }
            if (n == 22)
            {
                queue.Clear();
            }
            if (n == 23)
            {
                arrcopy = new string[sort_dict.Count];
                queue.CopyTo(arrcopy, sort_dict.Count);
            }
            if (n == 24)
            {
                Console.WriteLine(queue.Peek());
                Console.ReadLine();
            }
            if (n == 25)
            {
                string key = Console.ReadLine();
                Console.WriteLine(queue.Contains(key));
                Console.ReadLine();
            }
            if (n == 26)
            {
                Console.WriteLine(queue.GetHashCode());
                Console.ReadLine();
            }
            if (n == 27)
            {
                queue.Dequeue();
            }
            if (n == 28)
            {
                Console.WriteLine(queue.GetType());
                Console.ReadLine();
            }
            if (n == 29)
            {
                Console.WriteLine(queue.ToString());
                Console.ReadLine();
            }
            if (n == 30)
            {
                Console.WriteLine(queue.Equals(queue));
                Console.ReadLine();
            }

            if (n == 31)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                sort_list.Add(key, value);
            }
            if (n == 32)
            {
                sort_list.Clear();
            }
            if (n == 33)
            {
                arrcopy = new string[sort_list.Count];
                sort_list.Values.CopyTo(arrcopy, sort_list.Count);
            }
            if (n == 34)
            {
                string value = Console.ReadLine();
                Console.WriteLine(sort_list.ContainsValue(value));
                Console.ReadLine();
            }
            if (n == 35)
            {
                string key = Console.ReadLine();
                Console.WriteLine(sort_list.ContainsKey(key));
                Console.ReadLine();
            }
            if (n == 36)
            {
                Console.WriteLine(sort_list.GetHashCode());
                Console.ReadLine();
            }
            if (n == 37)
            {
                string key = Console.ReadLine();
                dict.Remove(key);
            }
            if (n == 38)
            {
                Console.WriteLine(sort_list.GetType());
                Console.ReadLine();
            }
            if (n == 39)
            {
                Console.WriteLine(sort_list.ToString());
                Console.ReadLine();
            }
            if (n == 40)
            {
                Console.WriteLine(dict.Equals(dict));
                Console.ReadLine();
            }
            if (n == 41)
            {
                break;
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CS_Using_HashSet
{
    class Program
    {
        static string[] _names = new string[]
        {
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita", "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita", "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita"
        };
        
        static string[] _uniqueNames = Enumerable.Range(1, 500).Select(i => $"Name{i}").ToArray();

        static void Main(string[] args)
        {
            // Check the length of our _uniqueNames array
            Console.WriteLine(_uniqueNames.Length);
            
            // Print content of _uniqueNames
            foreach (var name in _uniqueNames)
            {
                Console.WriteLine(name);
            }
            
            
            
            // Section 2: Eliminating Duplicates in C# HashSet --------------------------------------------------------
            
            
            Console.WriteLine("Using HashSet");
            //1. Defining String Array (Note that the string "mahesh" is repeated) 
            string[] names = new string[]
            {
                "mahesh",
                "vikram",
                "mahesh",
                "mayur",
                "suprotim",
                "saket",
                "manish"
            };
            //2. Length of Array and Printing array
            Console.WriteLine("Length of Array " + names.Length);
            Console.WriteLine();
            Console.WriteLine("The Data in Array");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            //3. Defining HashSet by passing an Array of string to it
            HashSet<string> hSet = new HashSet<string>(names);
            //4. Count of Elements in HashSet
            Console.WriteLine("Count of Data in HashSet " + hSet.Count);
            Console.WriteLine();
            //5. Printing Data in HashSet, this will eliminate duplication of "mahesh" 
            Console.WriteLine("Data in HashSet");
            foreach (var n in hSet)
            {
                Console.WriteLine(n);
            }

            
            // Section 3: Modify HashSet Using UnionWith() Method -----------------------------------------------------
            
            
            //1.
            string[] names1 = new string[]
            {
                "mahesh", "sabnis", "manish", "sharma", "saket", "karnik"
            };

            string[] names2 = new string[]
            {
                "suprotim", "agarwal", "vikram", "pendse", "mahesh", "mitkari"
            };
            
            //2.
            HashSet<string> hSetN1 = new HashSet<string>(names1);
            Console.WriteLine("Data in First HashSet");
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("_______________________________________________________________");
            HashSet<string> hSetN2 = new HashSet<string>(names2);
            Console.WriteLine("Data in Second HashSet");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("________________________________________________________________");
            
            //3.
            Console.WriteLine("Data After Union");
            hSetN1.UnionWith(hSetN2);
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Data in HashSet before using Except With");
            Console.WriteLine("_________________________________");
            
            //storing data of hSetN3 in temporary HashSet
            HashSet<string> hSetN3 = new HashSet<string>(names1);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using Except With");
            Console.WriteLine("_________________________________");
            hSetN3.ExceptWith(hSetN2);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }

            //storing data of hSetN3 in temporary HashSet
            HashSet<string> hSetN4 = new HashSet<string>(names1);
            Console.WriteLine("_________________________________");
            Console.WriteLine("Elements in both HashSet before using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            Console.WriteLine("HashSet 1");
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            Console.WriteLine("HashSet 4");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("_________________________________");
            Console.WriteLine("Using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            hSetN4.SymmetricExceptWith(hSetN2);
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }

            
            // Section 6: Checking performance of operations like Add, Remove, Contains on HashSet vs List. -----------
            
            Get_Add_Performance_HashSet_vs_List();
            Get_Contains_Performance_HashSet_vs_List();
            Get_Remove_Performance_HashSet_vs_List();

            Console.ReadLine();
        }

        static void Get_Add_Performance_HashSet_vs_List()
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while Adding Item");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in _uniqueNames)
            {
                lstNames.Add(s);
            }

            s2.Stop();
            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while Adding Item");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in _uniqueNames)
            {
                hStringNames.Add(s);
            }

            s1.Stop();
            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();
        }
        
        // This prints:
        /*
            ____________________________________
            List Performance while Adding Item

            1,696 ms

            Ends Here

            ____________________________________
            HashSet Performance while Adding Item

            0,012 ms

            Ends Here
            ____________________________________
            */
        
        // Using HashSets here is a lot faster, which appears to be an anomaly.
        // Aaaaand now I figured it out.
        // The data set supplied on the website contains mostly duplicates.
        // Making the collection stored as a hashset way smaller.
        // Thus contaminating the experiment.
        // Now we have a new _uniqueNames array that through a handy function creates 500 unique strings.
        // Name1, Name2, Name3, etc.
        // And now we can run the experiment again using _uniqueNames instead of _names.
        
        // This prints:
        /*  ____________________________________
            List Performance while Adding Item

            0,006 ms

            Ends Here

            ____________________________________
            HashSet Performance while Adding Item

            0,026 ms

            Ends Here
            ____________________________________
            */
        
        // This is a lot more reasonable, and lists are now faster than hashsets.
        // This is because the list can just add an element and be done.
        // While the hashset has to check if the element already exists in the hashset.

        static void Get_Contains_Performance_HashSet_vs_List()
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while checking Contains operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in _uniqueNames)
            {
                lstNames.Contains(s);
            }

            s2.Stop();
            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while checking Contains operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in _uniqueNames)
            {
                hStringNames.Contains(s);
            }

            s1.Stop();
            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();
        }
        
        // This prints:
        /*  ____________________________________
            List Performance while checking Contains operation

            0,002 ms

            Ends Here

            ____________________________________
            HashSet Performance while checking Contains operation

            0,004 ms

            Ends Here
            ____________________________________
            */
        




        static void Get_Remove_Performance_HashSet_vs_List()
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while performing Remove item operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in _names)
            {
                lstNames.Remove(s);
            }

            s2.Stop();
            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while performing Remove item operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in _names)
            {
                hStringNames.Remove(s);
            }

            s1.Stop();
            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();
        }
    }
}
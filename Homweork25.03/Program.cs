namespace ArrayList._3
{
    using System;
    using System.Collections;
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var arlist1 = new ArrayList();                
            var arlist2 = new ArrayList()
                    {
                        1, "Bill", " ", true, 4.5, null
                    };
                                       //to add an entire ARRAY, ARRAYLIST, HASHTABLE, SORTEDLIST, BITARRAY, QUEUE, STACK
                                       // use arlist1.AddRange(arlist2);
            arlist1.AddRange(arlist2); //to add an element in ArrayList use arlist1.Add("Hi");

            foreach(var item in arlist1) // to print ArrayList (arlist1) use this code
                Console.Write(item + ", ");

            for (int i = 0; i < arlist2.Count; i++) // or to print ArrayList (arlist2) use this code
                Console.Write(arlist2[i] + ", ");


            

            //insert an item in ArrayList
            ArrayList arlist3 = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

            arlist3.Insert(1, "Second Item");

            foreach (var val in arlist3)
                Console.WriteLine(val);
            //Use the InsertRange() method to insert a collection in an ArrayList at the specfied index.
            ArrayList arlist5 = new ArrayList()
                {
                    100, 200, 600
                };

            ArrayList arlist6 = new ArrayList()
                {
                    300, 400, 500
                };
            arlist5.InsertRange(2, arlist6);

            foreach (var item in arlist5)
                Console.Write(item + ", ");

            */

            // Remove Elements from ArrayList
            ArrayList arList = new ArrayList()
                {
                    1,
                    null,
                    "Bill",
                    300,
                    " ",
                    4.5f,
                    300,
                };

            arList.Remove(null); //Removes first occurance of null
            arList.RemoveAt(4); //Removes element at index 4
            arList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            foreach (var b in arList)
                Console.WriteLine(b + ", ");



            //Check for Elements
            //Use the Contains() method to determine whether the specified element exists in the ArrayList or not. It returns true if exists otherwise returns false.
            ArrayList arList1 = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f,
                    300
                };

            Console.WriteLine(arList1.Contains(300)); // true
            Console.WriteLine(arList1.Contains("Bill")); // true
            Console.WriteLine(arList1.Contains(10)); // false
            Console.WriteLine(arList1.Contains("Steve")); // false
        }
    }
}
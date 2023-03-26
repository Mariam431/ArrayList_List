namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);// nulls are allowed for reference type list

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };

            // using foreach loop to print List
            foreach(var c in cities)
                Console.WriteLine(c + ", ");
            // using for loop to print List
            for (int i = 0; i < cities.Count; i++)
                Console.WriteLine(cities[i]);




            //Adding array to list
            string[] cities1 = new string[3] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(cities1);

            var favouriteCities = new List<string>();

            // adding a List 
            favouriteCities.AddRange(popularCities);
            foreach (var c in favouriteCities)
                Console.WriteLine(c + ", ");

            //Inserts new element into List
            var numbers = new List<int>() { 10, 20, 30, 40 };

            numbers.Insert(1, 11);// inserts 11 at 1st index: after 10.

            foreach (var num in numbers)
                Console.Write(num);


            //remove elements from List
            var numbers2 = new List<int>() { 10, 20, 30, 40, 10 };

            numbers.Remove(10); // removes the first 10 from a list

            numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            //numbers.RemoveAt(10); //throws ArgumentOutOfRangeException

            foreach (var el in numbers2)
                Console.Write(el); //prints 20 30


            //Check elements in List
            var numbers4 = new List<int>() { 10, 20, 30, 40 };
            numbers4.Contains(10); // returns true
            numbers4.Contains(11); // returns false
            numbers4.Contains(20); // returns true








        }
    }
}
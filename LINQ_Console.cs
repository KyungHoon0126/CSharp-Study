using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            //var names = new List<string>()
            //{
            //    "KyungHoon",
            //    "Jinu",
            //    "SoonGwan",
            //    "YoungBin",
            //    "Abel",
            //};

            //var shortNames = names.Where(name => name.Length <= 8);

            //foreach(var item in shortNames)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-------------------------------------------");

            //shortNames = shortNames.OrderBy(name => name.ToUpper());

            //foreach(var item in shortNames)
            //{
            //    Console.WriteLine(item);
            //}



            var listOfNames = new List<string>()
            {
                "John Doe",
                "Jane Doe",
                "Jenna Doe",
                "Joe Doe"
            };

            // Query syntax
            var qNames = from name in listOfNames where name.Length <= 8 select name;

            // Method syntax
            // var mNames = listOfNames.Where(name => name.Length <= 8);
            var mNames = listOfNames.Where(x => x.Length <= 8);




            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 4, 8, 16, 32
            //};

            //var smallNumbers = numbers.Where(n => n < 10);

            //foreach(var n in smallNumbers)
            //{
            //    Console.WriteLine(n);
            //}

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 4, 8, 16, 32
            //};

            //var smallNumbers = numbers.Where(n => n > 1 && n != 4 && n < 10);

            //foreach(var n in smallNumbers)
            //{
            //    Console.WriteLine(n);
            //}



            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 4, 7, 8, 16, 29, 32, 64, 128
            //};
            //List<int> excludedNumbers = new List<int>()
            //{
            //    7, 29
            //};

            //var validNumbers = numbers.Where(n => !excludedNumbers.Contains(n));

            //foreach(var n in validNumbers)
            //{
            //    Console.WriteLine(n);
            //}


            List<User> listOfUsers = new List<User>()
            {
                new User() { Name = "John Doe", Age = 42 },
                new User() { Name = "Jane Doe", Age = 34 },
                new User() { Name = "Joe Doe", Age = 8 },
                new User() { Name = "Another Doe", Age = 15 },
            };

            // Method syntax
            var filteredUsersM = listOfUsers.Where(user => user.Name.StartsWith("J") && user.Age < 40);

            // Query syntax
            var filterUsersQ = from user in listOfUsers where user.Name.StartsWith("J") && user.Age < 40 select user;
            
            foreach(User user in filteredUsersM)
            {
                Console.WriteLine(user.Name + ": " + user.Age);
            }
        }
    }

    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

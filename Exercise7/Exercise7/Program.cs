using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise7
{
    internal class Program
    {
        public class User
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Adress { get; set; }
            public int DOB { get; set; }
        }

        public class Car
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }

        public class User2
        {
            
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public int Salary { get; set; }
        }
        static void Main(string[] args)
        {
            List<User> listuser = new List<User>
             {
                new User {ID=1, Name="Jhon", Adress="London", DOB= 2001-04-01 },
                new User {ID=2, Name="Lenny", Adress="New York", DOB=1977-12-11 },
                new User {ID=3, Name="Andrew", Adress="Boston", DOB=1987-02-22 },
                new User {ID=4, Name="Peter", Adress="Prague", DOB=1936-03-24 },
                new User {ID=5, Name="Anna", Adress="Bratislava", DOB=1973-11-18 },
                new User {ID=6, Name="Albert", Adress="Bratislava", DOB= 1940-12-11 },
                new User {ID=7, Name="Adam", Adress="Trnava", DOB=1983-12-01 },
                new User {ID=8, Name="Robert", Adress="Bratislava", DOB= 1935-05-15 },
                new User {ID=9, Name="Robert", Adress="Prague", DOB= 1988-03-14 },
            };
            IEnumerable<User> result = (from A in  listuser
                                           where A.Adress == "Bratislava"
                                        select A);

            result.ToList().ForEach(A => Console.WriteLine(A.Name));
        


            // b
            List<Car> listcar = new List<Car>
            {
                new Car {Name="Audi", Price=52642},
                new Car {Name="Mercedes",Price=57127},
                new Car {Name="Skoda", Price=9000},
                new Car {Name="Volvo", Price=29000},
                new Car {Name="Bently", Price=350000},
                new Car {Name="Citroen", Price=21000},
                new Car {Name="Humer", Price=41400},
                new Car {Name="Volkswagen", Price=21600},
            };
            IEnumerable<Car> resultcar = from B in listcar
                                           where B.Price > 30000 && B.Price< 100000
                                         select B;

            Console.WriteLine("Select the cars whose price is between 30000 and 100000.\n");

            resultcar.ToList().ForEach(B => Console.WriteLine(B.Name));
          


            List<User2> listuser2 = new List<User2>
            {
                new User2 {Firstname ="John", Lastname="Doe",Salary=1230},
                new User2 {Firstname ="Lucy", Lastname="Novak",Salary=670},
                new User2 {Firstname ="Ben", Lastname="Walter",Salary=2050},
                new User2 {Firstname ="Robin", Lastname="Brown",Salary=2300},
                new User2 {Firstname ="Amy", Lastname="Doe",Salary=1250},
                new User2 {Firstname ="Joe", Lastname="Draker",Salary=1190},
                new User2 {Firstname ="Janet", Lastname="Doe",Salary=980},
                new User2 {Firstname ="Albert", Lastname="Novak",Salary=1930},
            };
            //1Sort ascending by last name and salary
            IEnumerable<User2> resultuser2 = (from c in listuser2
                                             orderby c.Lastname ascending, c.Salary ascending
                                             select c);

            Console.WriteLine("Sort ascending by last name and salary\n");
            resultuser2.ToList().ForEach(c => Console.WriteLine($"{c.Lastname}, {c.Salary}"));
           

            //b
            IEnumerable<User2> result3 = (from User2 in listuser2
                                              where User2.Salary > 1500
                                              select User2);

            Console.WriteLine("Users who have salary higher than 1500\n");
            result3.ToList().ForEach(User2 => Console.WriteLine($"Salary: {User2.Salary}"));
            Console.ReadKey();
        }
    }
}



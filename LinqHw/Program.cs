using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqHw
{
    class Program
    {
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};


			// Task 01
			// all people aged 50 or more
			Console.WriteLine("===AGED 50 OR MORE===");

			List<string> aged50OrMore = people
									.Where(x => x.Age >= 50)
									.Select(x => x.FirstName)
									.ToList();
			aged50OrMore.ForEach(x => Console.WriteLine(x));



			// Task 02
			// all people name starts with B
			Console.WriteLine("===NAME STARTS WITH B===");

			List<Person> nameStartsWithB = people
										.Where(x => x.FirstName.StartsWith("B"))
										.ToList();
			nameStartsWithB.ForEach(x => Console.WriteLine(x.FirstName));

			// Task 03
			// first person whose surname starts with T
			Console.WriteLine("===LAST NAME STARTS WITH T===");
			List<Person> surnameWithT = people
										.Where(x => x.LastName.StartsWith("T"))
										.ToList();
			surnameWithT.ForEach(x => Console.WriteLine(x.LastName));

			// Task 04
			// find youngest and oldest person
			Console.WriteLine("===YOUNGEST AND OLDEST");
			
			List<string> youngestAndOldest = people
										.Where(x => x.Age == 18 || x.Age == 84)
										.Select(x => x.FirstName)
										.ToList();
			youngestAndOldest.ForEach(x => Console.WriteLine(x));



			// Task 05
			// find all male people aged 45 or more
			Console.WriteLine("===MALE OVER 45===");
			List<string> maleAgeOver45 = people
										.Where(x => x.Age > 45 && x.Gender == 'M')
										.Select(x => x.FirstName)
										.ToList();
			maleAgeOver45.ForEach(x => Console.WriteLine(x));

			// Task 06
			// find all females whose name starts with V
			Console.WriteLine("===FEMALE WHOSE NAME STARTS WITH V");
			List<string> femaleNameV = people
										.Where(x => x.FirstName.Substring(0, 1) == "V" && x.Gender == 'F')
										.Select(x => x.FirstName)
										.ToList();
			femaleNameV.ForEach(x => Console.WriteLine(x));





			// Task 07
			// find last female person older than 30 whose name starts with P
			Console.WriteLine("===LAST FEMALE WHOSE NAME STARTS WITH P===");
			Person firstFemaleP = people
										  .LastOrDefault(x => x.Age > 30 && x.Gender == 'F' && x.FirstName.StartsWith("P"));
			if (firstFemaleP == null)
			{
				Console.WriteLine("No such person");
			}
			else Console.WriteLine(firstFemaleP.FirstName);

			// Task 08
			// find first male younger than 40

			// Task 09
			// print the names of the male persons that have firstName longer than lastName
			Console.WriteLine("===MALE PERSONS WITH NAME LONGER THAN SURNAME===");
			List<string> maleNameLonger = people
										.Where(x => x.Gender == 'M' && x.FirstName.Length > x.LastName.Length)
										.Select(x => x.FirstName)
										.ToList();
			if (maleNameLonger.Count == 0)
			{
				Console.WriteLine("No such person");
			}
			else maleNameLonger.ForEach(x => Console.WriteLine(x));
			// Task 10
			// print the lastNames of the female persons that have odd number of ages
			Console.WriteLine("===FEMALE WITH ODD NUMBER OF AGE");
			List<string> femaleLastNameOddYears = people
										.Where(x => x.Age % 2 != 0 && x.Gender == 'F')
										.Select(x => x.FirstName)
										.ToList();
			femaleLastNameOddYears.ForEach(x => Console.WriteLine(x));


			Console.ReadLine();
		}
    }
}

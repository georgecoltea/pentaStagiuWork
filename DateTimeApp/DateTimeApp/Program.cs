using System;

namespace DateTimeApp
{
    class Program
    {

		public enum Gender{
			Male,
            Female
		}

        static void Main(string[] args)
        {
			int dateDay, dateMonth, dateYear, age;
            string str;
			char gender;
			int? validGender = null;

			Console.WriteLine("Enter the year: ");
			str = Console.ReadLine();
			dateYear = int.Parse(str);

			Console.WriteLine("Enter the month: ");
			str = Console.ReadLine();
			dateMonth = int.Parse(str);

			Console.WriteLine("Enter the day: ");
			str = Console.ReadLine();
			dateDay = int.Parse(str);

			Console.WriteLine("Enter the gender (M/F)");
			gender = Console.ReadKey().KeyChar;

			DateTime computedDate = new DateTime(dateYear, dateMonth, dateDay);
            DateTime currentDate = DateTime.Today;

			age = getAge(currentDate, computedDate);

			Console.WriteLine("Your age is: {0}", age);
           
			if(gender == 'm' || gender == 'M')
			{
				Gender genderMale = Gender.Male;
				validGender = (int)genderMale;
			}
			else
			{
				if(gender == 'f' || gender == 'F')
				{
					Gender genderFemale = Gender.Female;
					validGender = (int)genderFemale;
				}
			}

			if(validGender == null)
			{
				Console.WriteLine("The gender you enter is not valid! Please enter a valid gender M or F");
			}
			else
			{
				if(validGender == 0)
				{
					if (age >= 65)
						Console.WriteLine("The person is retired");
					else
						Console.WriteLine("The person will retire at 65");
				}
				else
				{
					if(age >= 63)
						Console.WriteLine("The person is retired");
                    else
                        Console.WriteLine("The person will retire at 63");
				}
			}



        }

		static int getAge(DateTime current, DateTime user)
		{
			int age = current.Year - user.Year;

			if (current.Month < user.Month)
			{
				age--;
			}
			else
			{
				if (current.Month == user.Month && current.Day < user.Day)
				{
                    age--;
                }
			}

			return age;
		}
    }
}

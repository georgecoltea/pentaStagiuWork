using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ReadFromFile
{

    class Program
    {
		private static List<string> people;

		private static void LoadFile()
		{
			List<string> peopleArray = new List<string>();

			using(StreamReader streamReader = new StreamReader("/Users/georgecoltea/Projects/ReadFromFile/ReadFromFile/people.txt"))
			{
				string line;

				while ((line = streamReader.ReadLine()) != null)
				{
					if (IsValid(line))
					{
						peopleArray.Add(line);
					}
					else
					{
						Console.WriteLine("Invalid name: {0}", line);
					}
				}
			}
			people = peopleArray;
		}

		private static bool IsValid(string name)
        {
            if (!Regex.IsMatch(name, @"^[\p{L}\p{M}]+$") || name.Trim().Equals(""))
            {
                return false;
            }

            return true;
        }

		private static void RemoveName()
        {
            int length = people.Count;
            Random random = new Random();

            int index = random.Next(0, length - 1);

            people.RemoveAt(index);
        }

		private static void AddName(string firstName, string secondName)
        {
			string[] newPerson = {firstName, secondName};

            foreach (string name in newPerson)
            {
                people.Add(name);
            }
        }

		private static void FileWrite(string fileName, FileMode fileMode, FileAccess fileAcces)
        {
            using (FileStream fileStream = new FileStream(fileName, fileMode, fileAcces))
            {

                foreach (string name in people)
                {
                    string newName = name + "\n";
                    byte[] array = Encoding.ASCII.GetBytes(newName);
                    foreach (byte toWrite in array)
                    {
                        fileStream.WriteByte(toWrite);
                    }
                }
                fileStream.Close();
            }
        }

		private static void ToNewFile()
        {
			string file = "/Users/georgecoltea/Projects/ReadFromFile/ReadFromFile/newFile.txt";
            try
            {
                FileWrite(file, FileMode.Open, FileAccess.Write);
            }
            catch (FileNotFoundException)
            {
                FileWrite(file, FileMode.OpenOrCreate, FileAccess.Write);
            }
        }

        static void Main(string[] args)
        {
			LoadFile();
            RemoveName();
            AddName("George", "Vlad");
            ToNewFile();

            Console.ReadKey();
        }
    }
}

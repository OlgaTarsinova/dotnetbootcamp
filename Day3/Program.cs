using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserList List = new UserList();

            // 1.1 cikliski vaica pievienot lietotajus
            while (true)
            {
                //1.1. Ievada vaardu
                string name = GetText();
                //1.2. Ievada datumu (DateTime.TryParse) cikliski 
                DateTime birthDate = GetDate();
                //1.3 Ievada dzimumu (Enum.TryParse) cikliski 
                UserProfile.Genders gender = GetGender();

                //2. Izsauc lietotaja pirvienoshanu ar vertibam augstak
                List.Add();
                //3. Ja neizdevas prievienot , attelo kludas pazinjojumu un sak 1. soli no jauna

            }
            Console.Read();

        }
        public static DateTime GetDate()
        {
            Console.Write("Enter date: ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime date))
            {
                return date;
            }
            else
            {
                Console.WriteLine("Invalid date!");
                return GetDate();

            }
        }
        public static string GetText()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            name = name.Trim(); 

            if(!String.IsNullOrEmpty(name))
            {
                return name;
            }
            else
            {
                Console.WriteLine("Empty text!");
                return GetText();
            }
        }
        public static UserProfile.Genders GetGender()
            
        {
            Console.Write("Enter gender: ");
            string value = Console.ReadLine();

            if (Enum.TryParse(value, true, out UserProfile.Genders gender))
            {
                return gender;
            }
            else
            {
                Console.WriteLine("Incorrect value!");
                return GetGender();
            }
        }
        }
    }


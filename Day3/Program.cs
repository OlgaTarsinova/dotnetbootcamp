using ConsoleHelpers;
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
            try
            {

                UserList List = new UserList();

                // 1.1 cikliski vaica pievienot lietotajus
                while (true)
                {
                    try
                    {
                        //1.1. Ievada vaardu
                        string name = ConsoleInput.GetText("Enter name: ");
                        //1.2. Ievada datumu (DateTime.TryParse) cikliski 
                        DateTime birthDate = ConsoleInput.GetDate("Enter birth date: ");
                        //1.3 Ievada dzimumu (Enum.TryParse) cikliski .
                        UserProfile.Genders gender = GetGender();

                        //2. Izsauc lietotaja pirvienoshanu ar vertibam augstak
                        List.Add(name, gender, birthDate);
                        //3. Ja neizdevas prievienot , attelo kludas pazinjojumu un sak 1. soli no jaunaRT

                        Console.WriteLine("Add another? (y/n)");
                        string input = Console.ReadLine().ToLower();
                        if(input == "n")
                        {
                            break;
                        }
                    }
                    catch (InputException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch(Exception ex)

                    {
                            Console.WriteLine("Unexpected error! {0}", ex.Message);
                    }
                
            Console.Read();

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


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
            while(true)
            {
                //1.1. Ievada vaardu
                //1.2. Ievada datumu (DateTime.TryParse) cikliski 
                //1.3 Ievada dzimumu (Enum.TryParse) cikliski 
                //2. Izsauc lietotaja pirvienoshanu ar vertibam augstak
                List.Add();
                //3. Ja neizdevas prievienot , attelo kludas pazinjojumu un sak 1. soli no jauna

            }
            Console.Read();


        }
    }
}

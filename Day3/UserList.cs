using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class UserList
    {
        private List<UserProfile> users = new List<UserProfile>();

        public void Add(string fullName, UserProfile.Genders gender, DateTime date)
        {
            // parbaudes
            //1. Datums nedrikst but nakotne
            //2. Datums nedrikst but mazaks par 01.01.1800.
            //3. Pilnais vards nedrikst parsniegt 20 simbolus

            //lietotaja izveide
            UserProfile user = new UserProfile(fullName, date, gender);

            // lietotaja pievienosana
            users.Add(user);

        }
    }

}

﻿using System;
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
            if(date > DateTime.Now)
                {
                throw new InputException("Birth date can not be in future!");
                }
            //2. Datums nedrikst but mazaks par 01.01.1800.
            if (date < new DateTime(1800, 1, 1))
           
                {
                throw new InputException("Birth date can't be less than 01.01.1800!");
                }
            //3. Pilnais vards nedrikst parsniegt 20 simbolus
            if (fullName.Length > 20)
                {
                throw new InputException("Full name too long!");
                }

            //lietotaja izveide
            UserProfile user = new UserProfile(fullName, date, gender);

            // lietotaja pievienosana
            users.Add(user);

            Console.WriteLine("User with age {0} added!", user.Age());

        }
    }

}

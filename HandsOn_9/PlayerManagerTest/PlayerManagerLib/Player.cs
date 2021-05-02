﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManagerLib
{
    public class Player
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Country { get; private set; }
        public int NoOfMatches { get; private set; }

        public Player(string name, int age, string country, int noOfMatches)
        {
            Name = name;
            Age = age;
            Country = country;
            NoOfMatches = noOfMatches;
        }

        public static Player RegisterNewPlayer(string name, IPlayerMapper playermapper = null)
        {
            if (playermapper == null)
            {
                playermapper = new PlayerMapper();
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Player name can't be empty.");
            }

            if (playermapper.IsPlayerNameExistsInDb(name))
            {
                throw new ArgumentException("Player name alredy exists.");
            }

            playermapper.AddNewPlayerIntoDb(name);
            return new Player(name, 23, "India", 30);
        }

    }
}

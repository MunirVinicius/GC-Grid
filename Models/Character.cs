using System;
using System.Collections.Generic;

namespace grandchase.Models
{
    public class Character
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public string Title { get; set;}
        public int attack { get; set;}
        public int hp { get; set;}
        public int defense { get; set;}

        public static List<Character> CreateCharacters()
        {
            return new List<Character>
            {
                new Character{Id = 1, Name = "Azin", Title = "Fist of Infinity", attack = 2500, hp = 5000, defense = 1300},
                new Character{Id = 2, Name = "Zero", Title = "TrailBlazer", attack = 2000, hp = 7000, defense = 2000},
                new Character{Id = 3, Name = "Dio", Title = "Sovereign of Evil", attack = 2300, hp = 6000, defense = 1250},
                new Character{Id = 4, Name = "Rey", Title = "Evil Lord", attack = 1800, hp = 5000, defense = 3000},
                new Character{Id = 5, Name = "Lass", Title = "Final Edge", attack = 3000, hp = 4500, defense = 1100},
                new Character{Id = 6, Name = "Mari", Title = "Seeker of Truth", attack = 2000, hp = 6500, defense = 1220}
            };
        }
    }
}
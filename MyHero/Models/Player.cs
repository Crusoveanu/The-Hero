using System;
using System.Collections.Generic;
using System.Text;

namespace MyHero.Models
{
    public class Player
    {
        //In case that we want to migrate into db
        public int Id { get; set; }
        public string Name = "Orderus";
        public int Health { get; set; }
        public int MinHealthValue = 70;
        public int MaxHealthValue = 100;

        public int Strength { get; set; }
        public int MinStrengthValue = 70;
        public int MaxStrengthValue = 80;
        public int Defence { get; set; }
        public int MinDefenceValue = 45;
        public int MaxDefenceValue = 55;
        public int Speed { get; set; }
        public int MinSpeedValue = 45;
        public int MaxSpeedValue = 55;
        public int Luck { get; set; }
        public int MinLuckValue = 10;
        public int MaxLuckValue = 30;
        //For trace records
        public bool Deleted { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public IEnumerable<Skill> Skills;
    }
}

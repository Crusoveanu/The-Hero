using System;
using System.Collections.Generic;
using System.Text;

namespace MyHero.Models
{
    public class Enemy
    {
        public int Id { get; set; }
        public int Health { get; set; }
        public int MinHealthValue = 60;
        public int MaxHealthValue = 90;

        public int Strength { get; set; }
        public int MinStrengthValue = 60;
        public int MaxStrengthValue = 90;
        public int Defence { get; set; }
        public int MinDefenceValue = 40;
        public int MaxDefenceValue = 60;
        public int Speed { get; set; }
        public int MinSpeedValue = 40;
        public int MaxSpeedValue = 60;
        public int Luck { get; set; }
        public int MinLuckValue = 25;
        public int MaxLuckValue = 40;
        //For trace records
        public bool Deleted { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}

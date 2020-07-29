using System;
using System.Collections.Generic;
using System.Text;

namespace MyHero.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string SkillName {get;set; }
        public string DescriptionName { get; set; }
        public int Chance { get; set; }
        public bool Deleted { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}

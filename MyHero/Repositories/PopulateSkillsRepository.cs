using MyHero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyHero.Repositories
{
    public class PopulateSkillsRepository : IPopulateSkills
    {
        public void PopulateSkill(List<Skill> skill)
        {
            skill.Add(new Skill { Id = 1,
                DescriptionName = "Strike twice while it’s his turn to attack; there’s a 10% chance he’ll use this skillevery time he attacks",
                SkillName = "Rapid strike",
                Chance = 10,
                Deleted = false,
                InsertDate = DateTime.Now
            });
            skill.Add(new Skill
            {
                Id = 2,
                DescriptionName = "Takes only half of the usual damage when an enemy attacks; there’s a 20% change he’ll use this skill every time he defends",
                SkillName = "Magic shield",
                Chance = 20,
                Deleted = false,
                InsertDate = DateTime.Now
            });
        }
    }
}

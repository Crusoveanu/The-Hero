using MyHero.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHero.Repositories
{
    public interface IPopulateSkills
    {
        void PopulateSkill(List<Skill> skill);
    }
}

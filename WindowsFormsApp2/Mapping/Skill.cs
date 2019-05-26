using System.Data.Linq.Mapping;
using System;
using System.Data.Linq;

namespace TestTask.Data
{
    [Table(Name = "skills")]
    public class Skill
    {
        [Column(Name = "skill_id", IsPrimaryKey = true, IsDbGenerated = true)]
        public long Id { get; set; }

        [Column(Name = "skill_name")]
        public string SkillName { get; set; }

        [Association(ThisKey = "Id", OtherKey = "SkillId")]
        public EntitySet<Ps> Ps { get; set; }

        public override string ToString()
        {
            return $"{SkillName}";

        }
    }
}
using System.Data.Linq.Mapping;
using System;
using System.Data.Linq;

namespace TestTask.Data
{
    [Table(Name = "ps")]
    public class Ps
    {
        [Column(Name = "ps_id", IsPrimaryKey = true, IsDbGenerated = true)]
        public long Id { get; set; }

        [Column(Name = "person_id")]
        public long PersonId { get; set; }

        [Column(Name = "skills_id")]
        public long SkillId { get; set; }


        private EntityRef<Employee> _Employee = new EntityRef<Employee>();
        private EntityRef<Skill> _Skill = new EntityRef<Skill>();

        [Association(Storage = nameof(_Employee), ThisKey = "PersonId")]
        public Employee Employee
        {
            get => _Employee.Entity;
            set => _Employee.Entity = value;
        }

        [Association(Storage = nameof(_Skill), ThisKey = "SkillId")]
        public Skill Skill
        {
            get => _Skill.Entity;
            set => _Skill.Entity = value;
        }
    }
}
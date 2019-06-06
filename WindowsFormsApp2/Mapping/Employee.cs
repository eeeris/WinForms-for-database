using System.Data.Linq.Mapping;
using System;
using System.Data.Linq;

namespace TestTask.Data
{

    [Table(Name = "employees")]
    public class Employee
    {
        [Column(Name="employee_id", IsPrimaryKey = true, IsDbGenerated = true)]
        public long Id { get; set; }

        [Column(Name="first name", CanBeNull = false)]
        public string FirstName { get; set; }
    
        [Column(Name="second name", CanBeNull = false)]
        public string SecondName { get; set; }
   
        [Column(Name="position", CanBeNull = false)]
        public string Position { get; set; }

        [Column(Name="education level", CanBeNull = true)] //TODO: переименовать поле в базе
        public string Education { get; set; }

        [Column(Name = "year of birth", CanBeNull = true)]
        public DateTime? YearOfBirth { get; set; }
    
        [Column(Name="address", CanBeNull = true)]
        public string Address { get; set; }

        [Column(Name="pasport number", CanBeNull = true)] //TODO: переименовать поле в базе
        public long? PassportNumber { get; set; }
    
        [Column(Name="phone number", CanBeNull = true)]
        public long? PhoneNumber { get; set; }
    
        [Column(Name="mail", CanBeNull = true)]
        public string Mail { get; set; }

        [Association(ThisKey = "Id", OtherKey = "PersonId")]
        public EntitySet<Ps> Ps { get; set; }

        public override string ToString()
        {
            return $"{SecondName}, {FirstName}";

        }
    }

}
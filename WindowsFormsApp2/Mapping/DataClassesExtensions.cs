namespace TestTask.Mapping
{
    public partial class employee
    {
        public override string ToString()
        {
            return $"{second_name}, {first_name}";

        }
    }

    public partial class skill
    {
        public override string ToString() => $"{skill_name}";
    }

    public partial class ps
    {
        public override string ToString() => $"{employee?.ToString() ?? person_id.ToString()}<->{skill?.ToString() ?? skills_id.ToString()}";//$"{person_id}<->{skills_id}";
    }
}
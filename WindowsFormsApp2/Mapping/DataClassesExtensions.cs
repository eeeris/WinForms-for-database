namespace TestTask.Mapping
{
    public partial class employees
    {
        public override string ToString()
        {
            return $"{second_name}, {first_name}";

        }
    }

    public partial class skills
    {
        public override string ToString() => $"{skill_name}";
    }

}
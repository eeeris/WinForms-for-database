using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestTask.Mapping;

namespace TestTask
{
    public static class DataProvider
    {

        public static IEnumerable<employee> GetEmployee(skill selectedSkill, string secondName)
        {
            using (var db = Program.OpenConnection())
            {
                var employees = db.employee;
                var sortedEmployees = from e in employees
                                      where selectedSkill == null || e.ps.Any(x => x.skill == selectedSkill)
                                      where e.second_name.StartsWith(secondName)
                                      orderby e.second_name
                                      select e;

                return sortedEmployees.ToList();
            }
        }

        public static IEnumerable<skill> GetSkill(employee selectedEmployee, string skillName)
        {
            using (var db = Program.OpenConnection())
            {
                var skills = db.skill;
                var sortedSkills = from s in skills
                                   where selectedEmployee == null || s.ps.Any(x => x.employee == selectedEmployee)
                                   where s.skill_name.StartsWith(skillName)
                                   orderby s.skill_name
                                   select s;
                return sortedSkills.ToList();


            }
        }

        public static void DaleteEmployee(employee selectedEmployee)
        {
            using (var db = Program.OpenConnection())
            {

                {

                    var ChangingEmployee = selectedEmployee as TestTask.Mapping.employee;

                    var em = db.employee.Where(x => x.employee_id == ChangingEmployee.employee_id).Single();

                    db.employee.DeleteOnSubmit(em);

                    var deleteSelectedPs = from ps in db.ps
                                           where ps.person_id == em.employee_id
                                           select ps;

                    db.ps.DeleteAllOnSubmit(deleteSelectedPs);
                }
                db.SubmitChanges();
            }
        }



        public static void DaleteSkill(skill selectedSkill)
        {
            using (var db = Program.OpenConnection())
            {
                {

                    var ChangingSkill = selectedSkill as TestTask.Mapping.skill;

                    var sk = db.skill.Where(x => x.skill_id == ChangingSkill.skill_id).Single();

                    db.skill.DeleteOnSubmit(sk);

                    var deleteSelectedPs = from ps in db.ps
                                           where ps.skills_id == sk.skill_id
                                           select ps;


                    db.ps.DeleteAllOnSubmit(deleteSelectedPs);
                }
                db.SubmitChanges();
            }

        }


        
        public static IEnumerable<(skill, bool)> UpdateCheckedListBoxSkills(employee changingEmployee)
        {
            using (var db = Program.OpenConnection())

            {
                var sortedSkills = from s in db.skill
                                   orderby s.skill_name
                                   select s;


                foreach (var skill in sortedSkills)
                {
                    bool isLinkedWithEmployee = false;
                    try
                    {
                        var em = db.employee.Where(x => x.employee_id == changingEmployee.employee_id).Single();
                        isLinkedWithEmployee = em.ps.Any(x => x.skill == skill);//"Доступ к ликвидированному объекту невозможен.
                    }
                    catch
                    {
                    }

                    yield return (skill, isLinkedWithEmployee);
                }
            }
        }



        public static IEnumerable<employee> UpdatecheckedListBoxEmployee()
        {
            using (var db = Program.OpenConnection())
            {
                var sortedEmployees = from e in db.employee
                                      orderby e.second_name
                                      select e;
                return sortedEmployees.ToList();
            }
        }


        public static skill AddNewSkillSupporting(skill addNewSkill)
        {
            using (var db = Program.OpenConnection())

            {
                var sk = db.skill.FirstOrDefault(x => x.skill_name == addNewSkill.skill_name);
                return sk;


            }
        }



        public static void AddNewSkillAndLinkWithEmployee(skill skillToAdd, IEnumerable<long> employeesIds)
        {
            using (var db = Program.OpenConnection())
            {
                db.skill.InsertOnSubmit(skillToAdd);
                db.SubmitChanges();

                foreach (var employeeId in employeesIds)
                {
                    bool isLinkedWithEmployee = skillToAdd.ps.Any(x => x.employee.employee_id == employeeId);
                    if (isLinkedWithEmployee == false)
                    {
                        var ps = new Mapping.ps { skills_id = skillToAdd.skill_id, person_id = employeeId };
                        db.ps.InsertOnSubmit(ps);
                    }
                }

                db.SubmitChanges();
            }

        }



    }
}

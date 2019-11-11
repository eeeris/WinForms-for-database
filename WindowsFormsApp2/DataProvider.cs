using System;
using System.Collections.Generic;
using System.Linq;

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



        public static void DeleteEmployee(long selectedEmployeeId)
        {
            using (var db = Program.OpenConnection())
            {
                {
                    var employee = db.employee.Where(x => x.employee_id == selectedEmployeeId).Single();

                    db.employee.DeleteOnSubmit(employee);

                    var deleteSelectedPs = from ps in db.ps
                                           where ps.person_id == employee.employee_id
                                           select ps;

                    db.ps.DeleteAllOnSubmit(deleteSelectedPs);
                }
                db.SubmitChanges();
            }
        }



        public static void DeleteSkill(long selectedSkillId)
        {
            using (var db = Program.OpenConnection())
            {
                {
                    var sk = db.skill.Where(x => x.skill_id == selectedSkillId).Single();

                    db.skill.DeleteOnSubmit(sk);

                    var deleteSelectedPs = from ps in db.ps
                                           where ps.skills_id == sk.skill_id
                                           select ps;

                    db.ps.DeleteAllOnSubmit(deleteSelectedPs);
                }
                db.SubmitChanges();
            }
        }



        public static IEnumerable<(skill, bool)> UpdateCheckedListBoxSkills(long changingEmployeeId)
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
                        var em = db.employee.Where(x => x.employee_id == changingEmployeeId).Single();
                        isLinkedWithEmployee = em.ps.Any(x => x.skill == skill);
                    }
                    catch
                    {
                    }

                    yield return (skill, isLinkedWithEmployee);
                }
            }
        }



        public static void AddOrChangeEmployee(long employeeId, IEnumerable<(long id, bool enabled)> skillsIds, Action<employee> employeeSetter)
        {
            using (var db = Program.OpenConnection())
            {
                var employees = db.employee;

                employee employeeToAdd = null;
                if (employeeId != 0)
                {
                    employeeToAdd = db.employee.First(x => x.employee_id == employeeId);
                }
                else
                {
                    employeeToAdd = new employee();
                    employees.InsertOnSubmit(employeeToAdd);
                }

                employeeSetter(employeeToAdd);

                db.SubmitChanges();

                foreach (var skill in skillsIds)
                {
                    var association = employeeToAdd.ps.FirstOrDefault(x => x.skill.skill_id == skill.id);
                    if (association == null && skill.enabled)
                    {
                        var ps = new Mapping.ps { person_id = employeeToAdd.employee_id, skills_id = skill.id };
                        db.ps.InsertOnSubmit(ps);
                    }
                    else if (association != null && !skill.enabled)
                    {
                        db.ps.DeleteOnSubmit(association);
                    }

                }
                db.SubmitChanges();
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



        public static skill FindAndExcludeDuplicateSkill (string skillName)
        {
            using (var db = Program.OpenConnection())
            {
                var sk = db.skill.FirstOrDefault(x => x.skill_name == skillName);
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
                        var ps = new ps { skills_id = skillToAdd.skill_id, person_id = employeeId };
                        db.ps.InsertOnSubmit(ps);
                    }
                }
                db.SubmitChanges();
            }

        }
    }
}
